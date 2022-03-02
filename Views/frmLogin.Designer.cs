
namespace Platform_Exam_V2.Views
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtMail = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bntLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.txtPassword);
            this.bunifuPanel1.Controls.Add(this.txtMail);
            this.bunifuPanel1.Controls.Add(this.bntLogin);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(385, 483);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Welcome";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(36, 238);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnIdleState = stateProperties4;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassword.PlaceholderText = "Enter your password";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(306, 50);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 15;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextMarginLeft = 3;
            this.txtPassword.TextMarginTop = 0;
            this.txtPassword.TextPlaceholder = "Enter your password";
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.WordWrap = true;
            // 
            // txtMail
            // 
            this.txtMail.AcceptsReturn = false;
            this.txtMail.AcceptsTab = false;
            this.txtMail.AnimationSpeed = 200;
            this.txtMail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMail.BackColor = System.Drawing.Color.Transparent;
            this.txtMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMail.BackgroundImage")));
            this.txtMail.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtMail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtMail.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtMail.BorderRadius = 10;
            this.txtMail.BorderThickness = 1;
            this.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtMail.DefaultText = "";
            this.txtMail.FillColor = System.Drawing.Color.White;
            this.txtMail.HideSelection = true;
            this.txtMail.IconLeft = null;
            this.txtMail.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.IconPadding = 10;
            this.txtMail.IconRight = null;
            this.txtMail.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.Lines = new string[0];
            this.txtMail.Location = new System.Drawing.Point(36, 130);
            this.txtMail.MaxLength = 32767;
            this.txtMail.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMail.Modified = false;
            this.txtMail.Multiline = false;
            this.txtMail.Name = "txtMail";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMail.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMail.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMail.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMail.OnIdleState = stateProperties8;
            this.txtMail.Padding = new System.Windows.Forms.Padding(3);
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMail.PlaceholderText = "Enter your mail";
            this.txtMail.ReadOnly = false;
            this.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.ShortcutsEnabled = true;
            this.txtMail.Size = new System.Drawing.Size(306, 54);
            this.txtMail.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtMail.TabIndex = 14;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMail.TextMarginBottom = 0;
            this.txtMail.TextMarginLeft = 3;
            this.txtMail.TextMarginTop = 0;
            this.txtMail.TextPlaceholder = "Enter your mail";
            this.txtMail.UseSystemPasswordChar = false;
            this.txtMail.WordWrap = true;
            // 
            // bntLogin
            // 
            this.bntLogin.AllowAnimations = true;
            this.bntLogin.AllowMouseEffects = true;
            this.bntLogin.AllowToggling = false;
            this.bntLogin.AnimationSpeed = 200;
            this.bntLogin.AutoGenerateColors = false;
            this.bntLogin.AutoRoundBorders = false;
            this.bntLogin.AutoSizeLeftIcon = true;
            this.bntLogin.AutoSizeRightIcon = true;
            this.bntLogin.BackColor = System.Drawing.Color.Transparent;
            this.bntLogin.BackColor1 = System.Drawing.Color.DeepSkyBlue;
            this.bntLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntLogin.BackgroundImage")));
            this.bntLogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bntLogin.ButtonText = "Login";
            this.bntLogin.ButtonTextMarginLeft = 0;
            this.bntLogin.ColorContrastOnClick = 45;
            this.bntLogin.ColorContrastOnHover = 45;
            this.bntLogin.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bntLogin.CustomizableEdges = borderEdges1;
            this.bntLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bntLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bntLogin.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bntLogin.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bntLogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.bntLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bntLogin.ForeColor = System.Drawing.Color.White;
            this.bntLogin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntLogin.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bntLogin.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bntLogin.IconMarginLeft = 11;
            this.bntLogin.IconPadding = 10;
            this.bntLogin.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntLogin.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bntLogin.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bntLogin.IconSize = 25;
            this.bntLogin.IdleBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.bntLogin.IdleBorderRadius = 10;
            this.bntLogin.IdleBorderThickness = 1;
            this.bntLogin.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.bntLogin.IdleIconLeftImage = null;
            this.bntLogin.IdleIconRightImage = null;
            this.bntLogin.IndicateFocus = false;
            this.bntLogin.Location = new System.Drawing.Point(115, 343);
            this.bntLogin.Name = "bntLogin";
            this.bntLogin.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bntLogin.OnDisabledState.BorderRadius = 10;
            this.bntLogin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bntLogin.OnDisabledState.BorderThickness = 1;
            this.bntLogin.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bntLogin.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bntLogin.OnDisabledState.IconLeftImage = null;
            this.bntLogin.OnDisabledState.IconRightImage = null;
            this.bntLogin.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bntLogin.onHoverState.BorderRadius = 10;
            this.bntLogin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bntLogin.onHoverState.BorderThickness = 1;
            this.bntLogin.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bntLogin.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bntLogin.onHoverState.IconLeftImage = null;
            this.bntLogin.onHoverState.IconRightImage = null;
            this.bntLogin.OnIdleState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.bntLogin.OnIdleState.BorderRadius = 10;
            this.bntLogin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bntLogin.OnIdleState.BorderThickness = 1;
            this.bntLogin.OnIdleState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.bntLogin.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bntLogin.OnIdleState.IconLeftImage = null;
            this.bntLogin.OnIdleState.IconRightImage = null;
            this.bntLogin.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bntLogin.OnPressedState.BorderRadius = 10;
            this.bntLogin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bntLogin.OnPressedState.BorderThickness = 1;
            this.bntLogin.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bntLogin.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bntLogin.OnPressedState.IconLeftImage = null;
            this.bntLogin.OnPressedState.IconRightImage = null;
            this.bntLogin.Size = new System.Drawing.Size(150, 39);
            this.bntLogin.TabIndex = 11;
            this.bntLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntLogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bntLogin.TextMarginLeft = 0;
            this.bntLogin.TextPadding = new System.Windows.Forms.Padding(0);
            this.bntLogin.UseDefaultRadiusAndThickness = true;
            this.bntLogin.Click += new System.EventHandler(this.bntLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 483);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bntLogin;
        private Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuTextBox txtMail;
        private System.Windows.Forms.Label label1;
    }
}