namespace GAppADDAutoUser
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginUser = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginBt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginProgPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.loginBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.selectPanel = new System.Windows.Forms.Panel();
            this.continuePick = new System.Windows.Forms.Button();
            this.sheetView = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.loginWorker = new System.ComponentModel.BackgroundWorker();
            this.spreadPanel = new System.Windows.Forms.Panel();
            this.sshLoad = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label19 = new System.Windows.Forms.Label();
            this.userField = new System.Windows.Forms.TextBox();
            this.manUsr = new System.Windows.Forms.CheckBox();
            this.authPanel = new System.Windows.Forms.Panel();
            this.pathLb = new System.Windows.Forms.TextBox();
            this.goAuth = new System.Windows.Forms.Button();
            this.browseKey = new System.Windows.Forms.Button();
            this.sshUser = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.manPass = new System.Windows.Forms.TextBox();
            this.surePanel = new System.Windows.Forms.Panel();
            this.notSure = new System.Windows.Forms.Button();
            this.sureClick = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.manAsk = new System.Windows.Forms.CheckBox();
            this.sheetBack = new System.Windows.Forms.Button();
            this.createBt = new System.Windows.Forms.Button();
            this.sheetLoad = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.sheetDesc = new System.Windows.Forms.TextBox();
            this.openSheet = new System.Windows.Forms.ListView();
            this.ehtpWorker = new System.ComponentModel.BackgroundWorker();
            this.connectionWorker = new System.ComponentModel.BackgroundWorker();
            this.loginPanel.SuspendLayout();
            this.loginProgPanel.SuspendLayout();
            this.selectPanel.SuspendLayout();
            this.spreadPanel.SuspendLayout();
            this.sshLoad.SuspendLayout();
            this.authPanel.SuspendLayout();
            this.surePanel.SuspendLayout();
            this.sheetLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello there!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please sign in with an account authorized to view the spreadsheets.";
            // 
            // loginUser
            // 
            this.loginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUser.Location = new System.Drawing.Point(203, 156);
            this.loginUser.Name = "loginUser";
            this.loginUser.Size = new System.Drawing.Size(251, 26);
            this.loginUser.TabIndex = 2;
            this.loginUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginPassword
            // 
            this.loginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPassword.Location = new System.Drawing.Point(203, 208);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.Size = new System.Drawing.Size(251, 26);
            this.loginPassword.TabIndex = 3;
            this.loginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginBt
            // 
            this.loginBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBt.Location = new System.Drawing.Point(286, 328);
            this.loginBt.Name = "loginBt";
            this.loginBt.Size = new System.Drawing.Size(85, 35);
            this.loginBt.TabIndex = 4;
            this.loginBt.Text = "Log in";
            this.loginBt.UseVisualStyleBackColor = true;
            this.loginBt.Click += new System.EventHandler(this.loginBt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Google Account:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.loginProgPanel);
            this.loginPanel.Controls.Add(this.label4);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.loginBt);
            this.loginPanel.Controls.Add(this.loginUser);
            this.loginPanel.Controls.Add(this.loginPassword);
            this.loginPanel.Location = new System.Drawing.Point(3, 2);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(656, 376);
            this.loginPanel.TabIndex = 7;
            // 
            // loginProgPanel
            // 
            this.loginProgPanel.Controls.Add(this.label7);
            this.loginProgPanel.Controls.Add(this.loginBar);
            this.loginProgPanel.Controls.Add(this.label5);
            this.loginProgPanel.Location = new System.Drawing.Point(179, 122);
            this.loginProgPanel.Name = "loginProgPanel";
            this.loginProgPanel.Size = new System.Drawing.Size(298, 133);
            this.loginProgPanel.TabIndex = 7;
            this.loginProgPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Pretend you\'re patient or something.";
            // 
            // loginBar
            // 
            this.loginBar.Location = new System.Drawing.Point(21, 53);
            this.loginBar.Name = "loginBar";
            this.loginBar.Size = new System.Drawing.Size(256, 23);
            this.loginBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loginBar.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hold up, signing in!";
            // 
            // selectPanel
            // 
            this.selectPanel.Controls.Add(this.continuePick);
            this.selectPanel.Controls.Add(this.sheetView);
            this.selectPanel.Controls.Add(this.label6);
            this.selectPanel.Controls.Add(this.label8);
            this.selectPanel.Location = new System.Drawing.Point(3, 2);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Size = new System.Drawing.Size(656, 376);
            this.selectPanel.TabIndex = 8;
            this.selectPanel.Visible = false;
            // 
            // continuePick
            // 
            this.continuePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuePick.Location = new System.Drawing.Point(286, 328);
            this.continuePick.Name = "continuePick";
            this.continuePick.Size = new System.Drawing.Size(85, 35);
            this.continuePick.TabIndex = 6;
            this.continuePick.Text = "Continue";
            this.continuePick.UseVisualStyleBackColor = true;
            this.continuePick.Click += new System.EventHandler(this.continuePick_Click);
            // 
            // sheetView
            // 
            this.sheetView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheetView.FormattingEnabled = true;
            this.sheetView.ItemHeight = 20;
            this.sheetView.Location = new System.Drawing.Point(76, 110);
            this.sheetView.Name = "sheetView";
            this.sheetView.ScrollAlwaysVisible = true;
            this.sheetView.Size = new System.Drawing.Size(505, 204);
            this.sheetView.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 55);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pick one.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(176, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Select a client spreadsheet to get started.";
            // 
            // loginWorker
            // 
            this.loginWorker.WorkerSupportsCancellation = true;
            this.loginWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loginWorker_DoWork);
            this.loginWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loginWorker_RunWorkerCompleted);
            // 
            // spreadPanel
            // 
            this.spreadPanel.Controls.Add(this.sshLoad);
            this.spreadPanel.Controls.Add(this.userField);
            this.spreadPanel.Controls.Add(this.manUsr);
            this.spreadPanel.Controls.Add(this.authPanel);
            this.spreadPanel.Controls.Add(this.manPass);
            this.spreadPanel.Controls.Add(this.surePanel);
            this.spreadPanel.Controls.Add(this.manAsk);
            this.spreadPanel.Controls.Add(this.sheetBack);
            this.spreadPanel.Controls.Add(this.createBt);
            this.spreadPanel.Controls.Add(this.sheetLoad);
            this.spreadPanel.Controls.Add(this.sheetDesc);
            this.spreadPanel.Controls.Add(this.openSheet);
            this.spreadPanel.Location = new System.Drawing.Point(3, 2);
            this.spreadPanel.Name = "spreadPanel";
            this.spreadPanel.Size = new System.Drawing.Size(656, 376);
            this.spreadPanel.TabIndex = 9;
            this.spreadPanel.Visible = false;
            // 
            // sshLoad
            // 
            this.sshLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sshLoad.Controls.Add(this.label17);
            this.sshLoad.Controls.Add(this.label18);
            this.sshLoad.Controls.Add(this.progressBar2);
            this.sshLoad.Controls.Add(this.label19);
            this.sshLoad.Location = new System.Drawing.Point(179, 122);
            this.sshLoad.Name = "sshLoad";
            this.sshLoad.Size = new System.Drawing.Size(298, 133);
            this.sshLoad.TabIndex = 9;
            this.sshLoad.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(-1, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(301, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "The time this takes depends solely on your connection speed. ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(61, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(176, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Pretend you\'re patient or something.";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(20, 53);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(256, 23);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar2.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(272, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "Hold up, connecting and adding user.\r\n";
            // 
            // userField
            // 
            this.userField.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.userField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userField.Location = new System.Drawing.Point(516, 327);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(131, 20);
            this.userField.TabIndex = 15;
            this.userField.Visible = false;
            // 
            // manUsr
            // 
            this.manUsr.AutoSize = true;
            this.manUsr.Location = new System.Drawing.Point(498, 328);
            this.manUsr.Name = "manUsr";
            this.manUsr.Size = new System.Drawing.Size(150, 17);
            this.manUsr.TabIndex = 14;
            this.manUsr.Text = "Manually enter username?";
            this.manUsr.UseVisualStyleBackColor = true;
            this.manUsr.CheckedChanged += new System.EventHandler(this.manUsr_CheckedChanged);
            // 
            // authPanel
            // 
            this.authPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.authPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.authPanel.Controls.Add(this.pathLb);
            this.authPanel.Controls.Add(this.goAuth);
            this.authPanel.Controls.Add(this.browseKey);
            this.authPanel.Controls.Add(this.sshUser);
            this.authPanel.Controls.Add(this.label16);
            this.authPanel.Controls.Add(this.label15);
            this.authPanel.Controls.Add(this.label13);
            this.authPanel.Controls.Add(this.label12);
            this.authPanel.Location = new System.Drawing.Point(179, 122);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(298, 133);
            this.authPanel.TabIndex = 13;
            this.authPanel.Visible = false;
            // 
            // pathLb
            // 
            this.pathLb.Enabled = false;
            this.pathLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLb.Location = new System.Drawing.Point(82, 82);
            this.pathLb.Multiline = true;
            this.pathLb.Name = "pathLb";
            this.pathLb.ReadOnly = true;
            this.pathLb.Size = new System.Drawing.Size(137, 38);
            this.pathLb.TabIndex = 10;
            // 
            // goAuth
            // 
            this.goAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goAuth.Location = new System.Drawing.Point(222, 89);
            this.goAuth.Name = "goAuth";
            this.goAuth.Size = new System.Drawing.Size(68, 28);
            this.goAuth.TabIndex = 8;
            this.goAuth.Text = "Continue";
            this.goAuth.UseVisualStyleBackColor = true;
            this.goAuth.Click += new System.EventHandler(this.goAuth_Click);
            // 
            // browseKey
            // 
            this.browseKey.Location = new System.Drawing.Point(10, 97);
            this.browseKey.Name = "browseKey";
            this.browseKey.Size = new System.Drawing.Size(66, 23);
            this.browseKey.TabIndex = 7;
            this.browseKey.Text = "Browse...";
            this.browseKey.UseVisualStyleBackColor = true;
            this.browseKey.Click += new System.EventHandler(this.browseKey_Click);
            // 
            // sshUser
            // 
            this.sshUser.Location = new System.Drawing.Point(82, 55);
            this.sshUser.Name = "sshUser";
            this.sshUser.Size = new System.Drawing.Size(207, 20);
            this.sshUser.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Private Key:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Username:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(283, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Enter an authorized username and private key to continue.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(98, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Authenticate";
            // 
            // manPass
            // 
            this.manPass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.manPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manPass.Location = new System.Drawing.Point(516, 351);
            this.manPass.Name = "manPass";
            this.manPass.Size = new System.Drawing.Size(131, 20);
            this.manPass.TabIndex = 0;
            this.manPass.Visible = false;
            // 
            // surePanel
            // 
            this.surePanel.BackColor = System.Drawing.Color.LightCoral;
            this.surePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surePanel.Controls.Add(this.notSure);
            this.surePanel.Controls.Add(this.sureClick);
            this.surePanel.Controls.Add(this.label14);
            this.surePanel.Location = new System.Drawing.Point(179, 122);
            this.surePanel.Name = "surePanel";
            this.surePanel.Size = new System.Drawing.Size(298, 133);
            this.surePanel.TabIndex = 12;
            this.surePanel.Visible = false;
            // 
            // notSure
            // 
            this.notSure.Location = new System.Drawing.Point(90, 85);
            this.notSure.Name = "notSure";
            this.notSure.Size = new System.Drawing.Size(117, 23);
            this.notSure.TabIndex = 4;
            this.notSure.Text = "No, I\'m not.";
            this.notSure.UseVisualStyleBackColor = true;
            this.notSure.Click += new System.EventHandler(this.notSure_Click);
            // 
            // sureClick
            // 
            this.sureClick.Location = new System.Drawing.Point(90, 53);
            this.sureClick.Name = "sureClick";
            this.sureClick.Size = new System.Drawing.Size(117, 23);
            this.sureClick.TabIndex = 3;
            this.sureClick.Text = "Yes, I\'m sure.";
            this.sureClick.UseVisualStyleBackColor = true;
            this.sureClick.Click += new System.EventHandler(this.sureClick_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(95, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Are you sure?";
            // 
            // manAsk
            // 
            this.manAsk.AutoSize = true;
            this.manAsk.Location = new System.Drawing.Point(498, 354);
            this.manAsk.Name = "manAsk";
            this.manAsk.Size = new System.Drawing.Size(149, 17);
            this.manAsk.TabIndex = 11;
            this.manAsk.Text = "Manually enter password?";
            this.manAsk.UseVisualStyleBackColor = true;
            this.manAsk.CheckedChanged += new System.EventHandler(this.manAsk_CheckedChanged);
            // 
            // sheetBack
            // 
            this.sheetBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheetBack.Location = new System.Drawing.Point(9, 331);
            this.sheetBack.Name = "sheetBack";
            this.sheetBack.Size = new System.Drawing.Size(65, 35);
            this.sheetBack.TabIndex = 10;
            this.sheetBack.Text = "Go back";
            this.sheetBack.UseVisualStyleBackColor = true;
            this.sheetBack.Click += new System.EventHandler(this.sheetBack_Click);
            // 
            // createBt
            // 
            this.createBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBt.Location = new System.Drawing.Point(260, 331);
            this.createBt.Name = "createBt";
            this.createBt.Size = new System.Drawing.Size(137, 35);
            this.createBt.TabIndex = 9;
            this.createBt.Text = "Create selected users";
            this.createBt.UseVisualStyleBackColor = true;
            this.createBt.Click += new System.EventHandler(this.createBt_Click);
            // 
            // sheetLoad
            // 
            this.sheetLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sheetLoad.Controls.Add(this.label11);
            this.sheetLoad.Controls.Add(this.label9);
            this.sheetLoad.Controls.Add(this.progressBar1);
            this.sheetLoad.Controls.Add(this.label10);
            this.sheetLoad.Location = new System.Drawing.Point(179, 122);
            this.sheetLoad.Name = "sheetLoad";
            this.sheetLoad.Size = new System.Drawing.Size(298, 133);
            this.sheetLoad.TabIndex = 8;
            this.sheetLoad.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "This takes a bit longer than login does.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Pretend you\'re patient or something.";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 53);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Hold up, grabbing the list.\r\n";
            // 
            // sheetDesc
            // 
            this.sheetDesc.BackColor = System.Drawing.SystemColors.Control;
            this.sheetDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sheetDesc.Enabled = false;
            this.sheetDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheetDesc.Location = new System.Drawing.Point(9, 9);
            this.sheetDesc.Name = "sheetDesc";
            this.sheetDesc.ReadOnly = true;
            this.sheetDesc.Size = new System.Drawing.Size(638, 37);
            this.sheetDesc.TabIndex = 2;
            this.sheetDesc.Text = "I AM DESCRIPTIVE";
            this.sheetDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openSheet
            // 
            this.openSheet.CheckBoxes = true;
            this.openSheet.Location = new System.Drawing.Point(9, 52);
            this.openSheet.Name = "openSheet";
            this.openSheet.Size = new System.Drawing.Size(638, 269);
            this.openSheet.TabIndex = 1;
            this.openSheet.UseCompatibleStateImageBehavior = false;
            this.openSheet.View = System.Windows.Forms.View.Details;
            // 
            // ehtpWorker
            // 
            this.ehtpWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ehtpWorker_DoWork);
            this.ehtpWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ehtpWorker_RunWorkerCompleted);
            // 
            // connectionWorker
            // 
            this.connectionWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.connectionWorker_DoWork);
            this.connectionWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.connectionWorker_RunWorkerCompleted);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 379);
            this.Controls.Add(this.spreadPanel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.selectPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "GAppADD";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.loginProgPanel.ResumeLayout(false);
            this.loginProgPanel.PerformLayout();
            this.selectPanel.ResumeLayout(false);
            this.selectPanel.PerformLayout();
            this.spreadPanel.ResumeLayout(false);
            this.spreadPanel.PerformLayout();
            this.sshLoad.ResumeLayout(false);
            this.sshLoad.PerformLayout();
            this.authPanel.ResumeLayout(false);
            this.authPanel.PerformLayout();
            this.surePanel.ResumeLayout(false);
            this.surePanel.PerformLayout();
            this.sheetLoad.ResumeLayout(false);
            this.sheetLoad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginUser;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Button loginBt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel selectPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker loginWorker;
        private System.Windows.Forms.Panel loginProgPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar loginBar;
        public System.Windows.Forms.ListBox sheetView;
        private System.Windows.Forms.Button continuePick;
        private System.Windows.Forms.Panel spreadPanel;
        private System.Windows.Forms.ListView openSheet;
        private System.Windows.Forms.TextBox sheetDesc;
        private System.ComponentModel.BackgroundWorker ehtpWorker;
        private System.Windows.Forms.Panel sheetLoad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button sheetBack;
        private System.Windows.Forms.Button createBt;
        private System.Windows.Forms.CheckBox manAsk;
        private System.Windows.Forms.TextBox manPass;
        private System.Windows.Forms.Panel surePanel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button notSure;
        private System.Windows.Forms.Button sureClick;
        private System.Windows.Forms.Panel authPanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox sshUser;
        private System.Windows.Forms.Button goAuth;
        private System.Windows.Forms.Button browseKey;
        private System.ComponentModel.BackgroundWorker connectionWorker;
        private System.Windows.Forms.TextBox pathLb;
        private System.Windows.Forms.Panel sshLoad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.CheckBox manUsr;
    }
}

