using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Google API 
using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.Spreadsheets;

// SSH API
using Renci.SshNet;

namespace GAppADDAutoUser
{

    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Global defines 
        public bool loginFailed = false;

        private void MainWindow_Load(object sender, EventArgs e)
        {
            loginPanel.Visible = true;
            loginProgPanel.Visible = false;
            selectPanel.Visible = false;
        }

        // Start Google Library Calls

        public void processLogin(string username, string password)
        {
            try
            {
                SpreadsheetsService getAcct = new SpreadsheetsService("GAppADDAutoUser");
                getAcct.setUserCredentials(username, password);

                SpreadsheetQuery query = new SpreadsheetQuery();
                SpreadsheetFeed feed = getAcct.Query(query);
                foreach (SpreadsheetEntry entry in feed.Entries)
                {
                    sheetView.Items.Add(entry.Title.Text.ToString());
                }
            }
            catch (Exception e)
            {
                string loginExc = e.ToString();
                if (loginExc.Contains("InvalidCredentials"))
                {
                    MessageBox.Show("You fatfingered the credentials. Try logging in again with the right ones.", "Error (how could you do this to me?)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The following error has occured: " + e.ToString(), "Error argh bah no:", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                loginFailed = true;
                loginWorker.CancelAsync();
            }
        }

        // End Google Library Calls

        // Start login handling

        private void loginBt_Click(object sender, EventArgs e)
        {
            if (loginUser.Text == "" | loginPassword.Text == "")
            {
                MessageBox.Show("One or both fields are empty. Try harder.", "Error (it's your fault though)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                loginProgPanel.Visible = true;
                loginWorker.RunWorkerAsync();
                loginBt.Text = "Working...";
                loginBt.Enabled = false;
            }
        }

        private void loginWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            processLogin(loginUser.Text, loginPassword.Text);
            Application.DoEvents();
        }

        private void loginWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loginWorker.Dispose();
            if (loginFailed == false)
            {
                loginPanel.Visible = false;
                loginProgPanel.Visible = false;
                selectPanel.Visible = true;
            }
            if (loginFailed == true)
            {
                loginPanel.Visible = true;
                loginProgPanel.Visible = false;
                selectPanel.Visible = false;
                loginUser.Clear();
                loginPassword.Clear();
                loginBt.Enabled = true;
                loginBt.Text = "Log in";
                loginFailed = false;
            }
        }

        // End login handling

        // Start custom populators

        private void continuePick_Click(object sender, EventArgs e)
        {
            string clientSheet = sheetView.SelectedItem.ToString();

            if (clientSheet.Contains("EHTP"))
            {
                populateEHTP();
                continuePick.Enabled = false;
            }
            else
            {
                MessageBox.Show("This client isn't supported yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sheetBack_Click(object sender, EventArgs e)
        {
            // Clean the slate
            openSheet.Items.Clear();
            openSheet.Columns.Clear();

            spreadPanel.Visible = false;
            sheetLoad.Visible = false;

            selectPanel.Visible = true;
            continuePick.Enabled = true;
        }

        private void manAsk_CheckedChanged(object sender, EventArgs e)
        {
            if (manAsk.Checked)
            {
                manPass.Visible = true;
            }
            if (!manAsk.Checked)
            {
                manPass.Visible = false;
            }
        }

        // Start custom populators

        // Custom Password Generator

        public string genGAppADDpass()
        {

            Random _random = new Random();
            int num0 = _random.Next(0, 26); // Zero to 25
            int num1 = _random.Next(0, 26); // Zero to 25
            int num2 = _random.Next(0, 26); // Zero to 25
            int num3 = _random.Next(0, 26); // Zero to 25
            int num4 = _random.Next(0, 26); // Zero to 25
            char let0 = (char)('a' + num0);
            char let1 = (char)('a' + num1);
            char let2 = (char)('a' + num2);
            char let3 = (char)('a' + num3);
            char let4 = (char)('a' + num4);

            string password = let0.ToString() + let1.ToString() + let2.ToString() + let3.ToString() + let4.ToString() + "_" + DateTime.Today.Year.ToString() + "!"; // "!" EXCLAMATION NATION
            return password;
        }

        // End Cred Gen

        public void populateEHTP()
        {
            openSheet.Columns.Add("", 20);
            openSheet.Columns.Add("Full Name", 125);
            openSheet.Columns.Add("Username", 85);
            openSheet.Columns.Add("Password", 85);
            openSheet.Columns.Add("Manager", 85);
            openSheet.Columns.Add("Mailing Lists", 225);
            openSheet.Columns.Add("Shared Folder Access", 225);
            openSheet.Columns.Add("Added by", 90);
            openSheet.Columns.Add("Timestamp", 90);
            sheetDesc.Text = "EHTP User Queue";
            selectPanel.Visible = false;
            spreadPanel.Visible = true;
            sheetLoad.Visible = true;

            int idx = sheetView.SelectedIndex;
            ehtpWorker.RunWorkerAsync(idx);

        }

        private void ehtpWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SpreadsheetsService getAcct = new SpreadsheetsService("GAppADDAutoUserEHTP");
            getAcct.setUserCredentials(loginUser.Text, loginPassword.Text);

            SpreadsheetQuery query = new SpreadsheetQuery();

            SpreadsheetFeed spreadFeed = getAcct.Query(query);
            SpreadsheetEntry spreadsheet = (SpreadsheetEntry)spreadFeed.Entries[Convert.ToInt32(e.Argument)];
            WorksheetFeed wsFeed = spreadsheet.Worksheets;
            WorksheetEntry worksheet = (WorksheetEntry)wsFeed.Entries[0];

            // No other way to do this loop because Microsoft sucks.

            // Full Name
            CellQuery fnQuery = new CellQuery(worksheet.CellFeedLink);
            fnQuery.MinimumColumn = 2;
            fnQuery.MinimumRow = 2;
            fnQuery.MaximumColumn = 2;
            CellFeed fnFeed = getAcct.Query(fnQuery);

            // User Name
            CellQuery unQuery = new CellQuery(worksheet.CellFeedLink);
            unQuery.MinimumColumn = 8;
            unQuery.MinimumRow = 2;
            unQuery.MaximumColumn = 8;
            CellFeed unFeed = getAcct.Query(unQuery);

            // Password
            CellQuery pwQuery = new CellQuery(worksheet.CellFeedLink);
            pwQuery.MinimumColumn = 7;
            pwQuery.MinimumRow = 2;
            pwQuery.MaximumColumn = 7;
            CellFeed pwFeed = getAcct.Query(pwQuery);

            // Managers
            CellQuery mgQuery = new CellQuery(worksheet.CellFeedLink);
            mgQuery.MinimumColumn = 3;
            mgQuery.MinimumRow = 2;
            mgQuery.MaximumColumn = 3;
            CellFeed mgFeed = getAcct.Query(mgQuery);

            // Mailing Lists
            CellQuery mlQuery = new CellQuery(worksheet.CellFeedLink);
            mlQuery.MinimumColumn = 4;
            mlQuery.MinimumRow = 2;
            mlQuery.MaximumColumn = 4;
            CellFeed mlFeed = getAcct.Query(mlQuery);

            // SFA
            CellQuery sfaQuery = new CellQuery(worksheet.CellFeedLink);
            sfaQuery.MinimumColumn = 5;
            sfaQuery.MinimumRow = 2;
            sfaQuery.MaximumColumn = 5;
            CellFeed sfaFeed = getAcct.Query(sfaQuery);

            // Added By
            CellQuery abQuery = new CellQuery(worksheet.CellFeedLink);
            abQuery.MinimumColumn = 6;
            abQuery.MinimumRow = 2;
            abQuery.MaximumColumn = 6;
            CellFeed abFeed = getAcct.Query(abQuery);

            // Timestamp
            CellQuery tsQuery = new CellQuery(worksheet.CellFeedLink);
            tsQuery.MinimumColumn = 1;
            tsQuery.MinimumRow = 2;
            tsQuery.MaximumColumn = 1;
            CellFeed tsFeed = getAcct.Query(tsQuery);

            string[] rowData = new string[9];

            // Row count (cast me because I'm special)
            int rowCt = (Convert.ToInt32(worksheet.Rows) - 98);

            for (int i = 0; i < rowCt; i++)
            {
                try
                {
                    CellEntry fullName = (CellEntry)fnFeed.Entries[i];
                    CellEntry passWord = (CellEntry)pwFeed.Entries[i];
                    CellEntry userName = (CellEntry)unFeed.Entries[i];
                    CellEntry managerPerson = (CellEntry)mgFeed.Entries[i];
                    CellEntry mLists = (CellEntry)mlFeed.Entries[i];
                    CellEntry sfAccess = (CellEntry)sfaFeed.Entries[i];
                    CellEntry addedBy = (CellEntry)abFeed.Entries[i];
                    CellEntry timeStamp = (CellEntry)tsFeed.Entries[i];

                    // this irritates me
                    rowData[0] = "";
                    rowData[1] = fullName.Value;
                    rowData[2] = userName.Value;
                    rowData[3] = passWord.Value;
                    rowData[4] = managerPerson.Value;
                    rowData[5] = mLists.Value;
                    rowData[6] = sfAccess.Value;
                    rowData[7] = addedBy.Value;
                    rowData[8] = timeStamp.Value;
                    ListViewItem rowLvi = new ListViewItem(rowData);
                    // cross thread calling ghetto style
                    this.Invoke(new Action(() => { openSheet.Items.Add(rowLvi); }));
                }
                catch (Exception oops)
                {
                    string error = oops.ToString();
                    if (error.Contains("Index was out of range"))
                    {

                        CellEntry fullName = (CellEntry)fnFeed.Entries[i];
                        CellEntry managerPerson = (CellEntry)mgFeed.Entries[i];
                        CellEntry mLists = (CellEntry)mlFeed.Entries[i];
                        CellEntry sfAccess = (CellEntry)sfaFeed.Entries[i];
                        CellEntry addedBy = (CellEntry)abFeed.Entries[i];
                        CellEntry timeStamp = (CellEntry)tsFeed.Entries[i];

                        // this irritates me more the second time around
                        rowData[0] = "";
                        rowData[1] = fullName.Value;
                        rowData[2] = "";
                        rowData[3] = "";
                        rowData[4] = managerPerson.Value;
                        rowData[5] = mLists.Value;
                        rowData[6] = sfAccess.Value;
                        rowData[7] = addedBy.Value;
                        rowData[8] = timeStamp.Value;
                        ListViewItem rowLvi = new ListViewItem(rowData);
                        // cross thread calling ghetto style
                        this.Invoke(new Action(() => { openSheet.Items.Add(rowLvi); }));
                    }

                    else
                    {
                        System.Windows.Forms.MessageBox.Show("The following error has occured: " + oops.ToString(), "Error argh bah no:", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ehtpWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sheetLoad.Visible = false;
        }

        private void createBt_Click(object sender, EventArgs e)
        {
            if ((manUsr.Checked || manAsk.Checked) && openSheet.CheckedItems.Count > 1)
            {
                MessageBox.Show("Manually specifying usernames and/or passwords is a per user action. Please deselect those features if doing a batch query.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            surePanel.Visible = true;
            createBt.Enabled = false;
            sheetBack.Enabled = false;
            manPass.Enabled = false;
            manAsk.Enabled = false;
            manUsr.Enabled = false;
        }

        private void sureClick_Click(object sender, EventArgs e)
        {
            surePanel.Visible = false;
            authPanel.Visible = true;
        }

        private void notSure_Click(object sender, EventArgs e)
        {
            surePanel.Visible = false;
            createBt.Enabled = true;
            sheetBack.Enabled = true;
            manPass.Enabled = true;
            manAsk.Enabled = true;
            manUsr.Enabled = true;
        }

        private void browseKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog findKey = new OpenFileDialog();

            findKey.Filter = "PuttyGen PPK Keys (*.ppk)|*.ppk|All files (*.*)|*.*";
            findKey.FilterIndex = 2;
            findKey.RestoreDirectory = true;

            if (findKey.ShowDialog() == DialogResult.OK)
            {
                pathLb.Text = findKey.FileName;
            }

        }

        private void goAuth_Click(object sender, EventArgs e)
        {
            sshLoad.Visible = true;
            connectionWorker.RunWorkerAsync();
        }

        private void connectionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                SshClient client = new SshClient("50.75.205.26", 22, sshUser.Text, new PrivateKeyFile(System.IO.File.OpenRead(pathLb.Text)));
                client.Connect();
                    
                this.Invoke(new Action(() =>
                {

                    foreach (ListViewItem item in openSheet.CheckedItems)
                    {
                        string[] splitName = item.SubItems[1].Text.ToString().Split(' ');

                        string addPassword = genGAppADDpass();

                        if (manAsk.Checked && !manUsr.Checked)
                        {
                            var query = client.RunCommand("net user " + splitName[0][0].ToString() + splitName[1] + " " + manPass.Text + " /add /passwordreq:yes /fullname:\"" + item.SubItems[1].Text.ToString() + "\" /domain");
                            query.Execute();
                            MessageBox.Show("User " + splitName[0][0].ToString() + splitName[1] + " created with the password " + manPass.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            updateEhtpSheet(addPassword, splitName[0][0].ToString() + splitName[1], item.Index);
                        }
                        if (manUsr.Checked && !manAsk.Checked)
                        {
                            var query = client.RunCommand("net user " + userField.Text + " " + addPassword + " /add /passwordreq:yes /fullname:\"" + item.SubItems[1].Text.ToString() + "\" /domain");
                            query.Execute();
                            MessageBox.Show("User " + userField.Text + " created with the password " + addPassword, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            updateEhtpSheet(addPassword, userField.Text, item.Index);
                        }
                        if (manUsr.Checked && manAsk.Checked)
                        {
                            var query = client.RunCommand("net user " + userField.Text + " " + manPass.Text + " /add /passwordreq:yes /fullname:\"" + item.SubItems[1].Text.ToString() + "\" /domain");
                            query.Execute();
                            MessageBox.Show("User " + userField.Text + " created with the password " + manPass.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            updateEhtpSheet(manPass.Text, userField.Text, item.Index);
                        }
                        if (!manAsk.Checked && !manUsr.Checked)
                        {

                            var query = client.RunCommand("net user " + splitName[0][0].ToString() + splitName[1] + " " + addPassword + " /add /passwordreq:yes /fullname:\"" + item.SubItems[1].Text.ToString() + "\" /domain");
                            query.Execute();
                            MessageBox.Show("User " + splitName[0][0].ToString() + splitName[1] + " created with the password " + addPassword, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            updateEhtpSheet(addPassword, splitName[0][0].ToString() + splitName[1], Convert.ToInt32(item.Index));
                            //MessageBox.Show("net user " + splitName[0][1].ToString() + splitName[1] + " /add /passwordreq:yes /fullname:\"" + item.SubItems[1].Text.ToString() + "\"");

                        }

                        if (item.SubItems[6].Text.Contains("EH Admin"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group EHAdmin " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group EHAdmin " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("SA Admin"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group SAAdmin " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group SAAdmin " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("EHTP Staff"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"EHTP Staff\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"EHTP Staff\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("Finance"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"Finance Security\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"Finance Security\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("Fund Development"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"Fund Development\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"Fund Development\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("HR Access"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"HR Access\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"HR Access\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("HR Management"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"HRMgmt\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"HRMgmt\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("Human Resources"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"Human Resources Security\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"Human Resources Security\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("EH Management"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"Management Security\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"Management Security\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("Program Staff"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"Program Staff Security\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"Program Staff Security\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("SA Finance"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"SAFinance\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"SAFinance\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("SA Report Cards"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"SAReportCards\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"SAReportCards\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("SA Social Work"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"SASocialWork\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"SASocialWork\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("SA Teachers"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"SATeachers\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"SATeachers\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("SA Staff"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"Scholars Academy Staff\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"Scholars Academy Staff\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("Senior Management"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"SeniorManagement\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"SeniorManagement\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("Student"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"Student Security\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"Student Security\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("Volunteer Management"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"Volunteer Management Security\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"Volunteer Management Security\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                        if (item.SubItems[6].Text.Contains("VPN Access"))
                        {
                            if (manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"VPN Access\" " + userField.Text + " /add");
                            }
                            if (!manUsr.Checked)
                            {
                                var sfQuery = client.RunCommand("net group \"VPN Access\" " + splitName[0][0].ToString() + splitName[1] + " /add");
                            }
                        }
                    }
                }));
            }
            catch (Exception conExc)
            {
                MessageBox.Show("The following error has occured: " + conExc.ToString(), "Uh-oh.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //
            }
        }

        private void connectionWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sshLoad.Visible = false;
            authPanel.Visible = false;
            createBt.Enabled = true;
            sheetBack.Enabled = true;
            manPass.Enabled = true;
            manAsk.Enabled = true;
            manUsr.Enabled = true;

            openSheet.Items.Clear();
            openSheet.Columns.Clear();

            populateEHTP();
        }

        private void updateEhtpSheet(string passyword, string useryword, int indyex)
        {
            SpreadsheetsService getAcct = new SpreadsheetsService("GAppADDAutoUserEHTP");
            getAcct.setUserCredentials(loginUser.Text, loginPassword.Text);

            SpreadsheetQuery spreadQuery = new SpreadsheetQuery();

            SpreadsheetFeed spreadFeed = getAcct.Query(spreadQuery);
            SpreadsheetEntry spreadsheet = (SpreadsheetEntry)spreadFeed.Entries[sheetView.SelectedIndex];
            WorksheetFeed wsFeed = spreadsheet.Worksheets;
            WorksheetEntry worksheet = (WorksheetEntry)wsFeed.Entries[0];

            CellQuery cellQuery = new CellQuery(worksheet.CellFeedLink);
            cellQuery.ReturnEmpty = ReturnEmptyCells.yes;

            CellFeed cellFeed = getAcct.Query(cellQuery);


            foreach (CellEntry cell in cellFeed.Entries)
            {
                string uriStr = cell.SelfUri.ToString();

                if (uriStr.Contains("R" + Convert.ToString(indyex + 2) + "C7"))
                {
                    cell.InputValue = passyword;
                    cell.Update();
                    
                }
                if (uriStr.Contains("R" + Convert.ToString(indyex + 2) + "C8"))
                {
                    cell.InputValue = useryword;
                    cell.Update();
                }
            }
        }

        private void manUsr_CheckedChanged(object sender, EventArgs e)
        {
            if (manUsr.Checked)
            {
                userField.Visible = true;
            }
            if (!manUsr.Checked)
            {
                userField.Visible = false;
            }
        }


        // End custom populators





    }
}
