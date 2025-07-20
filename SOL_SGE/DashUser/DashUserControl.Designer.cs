using System.Web.UI.WebControls;

namespace SOL_SGE.DashUser
{
    partial class DashUserControl
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

        public class MiBoton : Button
        {
            public MiBoton ()
            {
                this.BackColor = System.Drawing.Color.Black;
                
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnFinanzas = new System.Windows.Forms.Button();
            this.btnNotificaciones = new System.Windows.Forms.Button();
            this.btnCalificaciones = new System.Windows.Forms.Button();
            this.btnClassroom = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMInimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelClassroom = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.llbGetName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.panelInicio);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 634);
            this.panel1.TabIndex = 0;
            // 
            // panelInicio
            // 
            this.panelInicio.AutoSize = true;
            this.panelInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(134)))), ((int)(((byte)(169)))));
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicio.Location = new System.Drawing.Point(170, 111);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelInicio.Size = new System.Drawing.Size(830, 523);
            this.panelInicio.TabIndex = 3;
            this.panelInicio.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInicio_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(170, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(830, 86);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.btnCerrarSesion);
            this.panel3.Controls.Add(this.btnPerfil);
            this.panel3.Controls.Add(this.btnFinanzas);
            this.panel3.Controls.Add(this.btnNotificaciones);
            this.panel3.Controls.Add(this.btnCalificaciones);
            this.panel3.Controls.Add(this.btnClassroom);
            this.panel3.Controls.Add(this.btnInicio);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 609);
            this.panel3.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrarSesion.Image = global::SOL_SGE.Properties.Resources.Logout;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 563);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(170, 34);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPerfil.AutoSize = true;
            this.btnPerfil.BackColor = System.Drawing.Color.Black;
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPerfil.Image = global::SOL_SGE.Properties.Resources.Profile;
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerfil.Location = new System.Drawing.Point(0, 447);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPerfil.Size = new System.Drawing.Size(178, 44);
            this.btnPerfil.TabIndex = 6;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnFinanzas
            // 
            this.btnFinanzas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFinanzas.AutoSize = true;
            this.btnFinanzas.BackColor = System.Drawing.Color.Black;
            this.btnFinanzas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinanzas.FlatAppearance.BorderSize = 0;
            this.btnFinanzas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnFinanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanzas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinanzas.Image = global::SOL_SGE.Properties.Resources.Financial_Analytics;
            this.btnFinanzas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinanzas.Location = new System.Drawing.Point(0, 383);
            this.btnFinanzas.Name = "btnFinanzas";
            this.btnFinanzas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFinanzas.Size = new System.Drawing.Size(178, 44);
            this.btnFinanzas.TabIndex = 5;
            this.btnFinanzas.Text = "Finanzas";
            this.btnFinanzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinanzas.UseVisualStyleBackColor = false;
            this.btnFinanzas.Click += new System.EventHandler(this.btnFinanzas_Click);
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNotificaciones.AutoSize = true;
            this.btnNotificaciones.BackColor = System.Drawing.Color.Black;
            this.btnNotificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotificaciones.FlatAppearance.BorderSize = 0;
            this.btnNotificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNotificaciones.Image = global::SOL_SGE.Properties.Resources.Report_Card;
            this.btnNotificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotificaciones.Location = new System.Drawing.Point(0, 319);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNotificaciones.Size = new System.Drawing.Size(181, 46);
            this.btnNotificaciones.TabIndex = 4;
            this.btnNotificaciones.Text = "Notificaciones";
            this.btnNotificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotificaciones.UseVisualStyleBackColor = false;
            this.btnNotificaciones.Click += new System.EventHandler(this.btnNotificaciones_Click);
            // 
            // btnCalificaciones
            // 
            this.btnCalificaciones.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCalificaciones.AutoSize = true;
            this.btnCalificaciones.BackColor = System.Drawing.Color.Black;
            this.btnCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalificaciones.FlatAppearance.BorderSize = 0;
            this.btnCalificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalificaciones.Image = global::SOL_SGE.Properties.Resources.Ratings;
            this.btnCalificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalificaciones.Location = new System.Drawing.Point(0, 253);
            this.btnCalificaciones.Name = "btnCalificaciones";
            this.btnCalificaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCalificaciones.Size = new System.Drawing.Size(178, 47);
            this.btnCalificaciones.TabIndex = 3;
            this.btnCalificaciones.Text = "Calificaciones";
            this.btnCalificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalificaciones.UseVisualStyleBackColor = false;
            this.btnCalificaciones.Click += new System.EventHandler(this.btnCalificaciones_Click);
            // 
            // btnClassroom
            // 
            this.btnClassroom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClassroom.AutoSize = true;
            this.btnClassroom.BackColor = System.Drawing.Color.Black;
            this.btnClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassroom.FlatAppearance.BorderSize = 0;
            this.btnClassroom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassroom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClassroom.Image = global::SOL_SGE.Properties.Resources.Google_Classroom;
            this.btnClassroom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClassroom.Location = new System.Drawing.Point(0, 190);
            this.btnClassroom.Name = "btnClassroom";
            this.btnClassroom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClassroom.Size = new System.Drawing.Size(178, 45);
            this.btnClassroom.TabIndex = 2;
            this.btnClassroom.Text = "Classroom";
            this.btnClassroom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClassroom.UseVisualStyleBackColor = false;
            this.btnClassroom.Click += new System.EventHandler(this.btnClassroom_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnInicio.AutoSize = true;
            this.btnInicio.BackColor = System.Drawing.Color.Black;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInicio.Image = global::SOL_SGE.Properties.Resources.home;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInicio.Location = new System.Drawing.Point(0, 128);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInicio.Size = new System.Drawing.Size(178, 44);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 86);
            this.panel5.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel2.Controls.Add(this.btnMax);
            this.panel2.Controls.Add(this.btnMInimize);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 25);
            this.panel2.TabIndex = 0;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = global::SOL_SGE.Properties.Resources.Maximize_Window;
            this.btnMax.Location = new System.Drawing.Point(946, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 20);
            this.btnMax.TabIndex = 3;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMInimize
            // 
            this.btnMInimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMInimize.FlatAppearance.BorderSize = 0;
            this.btnMInimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMInimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMInimize.Image = global::SOL_SGE.Properties.Resources.Subtract;
            this.btnMInimize.Location = new System.Drawing.Point(915, 2);
            this.btnMInimize.Name = "btnMInimize";
            this.btnMInimize.Size = new System.Drawing.Size(25, 20);
            this.btnMInimize.TabIndex = 2;
            this.btnMInimize.UseVisualStyleBackColor = true;
            this.btnMInimize.Click += new System.EventHandler(this.btnMInimize_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SMS AJESHA";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SOL_SGE.Properties.Resources.Close1;
            this.button1.Location = new System.Drawing.Point(975, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 20);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelClassroom
            // 
            this.panelClassroom.Location = new System.Drawing.Point(0, 0);
            this.panelClassroom.Name = "panelClassroom";
            this.panelClassroom.Size = new System.Drawing.Size(200, 100);
            this.panelClassroom.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel11.Location = new System.Drawing.Point(595, 289);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 100);
            this.panel11.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel10.Location = new System.Drawing.Point(340, 289);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 100);
            this.panel10.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel9.Location = new System.Drawing.Point(43, 289);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 100);
            this.panel9.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel8.Location = new System.Drawing.Point(595, 103);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 100);
            this.panel8.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel7.Location = new System.Drawing.Point(340, 103);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel6.Location = new System.Drawing.Point(43, 103);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(27, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tus Materias";
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel12.Controls.Add(this.llbGetName);
            this.panel12.Controls.Add(this.label3);
            this.panel12.Location = new System.Drawing.Point(528, 22);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(290, 44);
            this.panel12.TabIndex = 4;
            // 
            // llbGetName
            // 
            this.llbGetName.AutoSize = true;
            this.llbGetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbGetName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.llbGetName.Location = new System.Drawing.Point(95, 11);
            this.llbGetName.Name = "llbGetName";
            this.llbGetName.Size = new System.Drawing.Size(179, 20);
            this.llbGetName.TabIndex = 2;
            this.llbGetName.Text = "GetNombre(Estudiante)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(7, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Estudiante: ";
            // 
            // DashUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 634);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashUserControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashUserControl";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClassroom;
        private System.Windows.Forms.Button btnNotificaciones;
        private System.Windows.Forms.Button btnCalificaciones;
        private System.Windows.Forms.Button btnFinanzas;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelClassroom;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Button btnMInimize;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label llbGetName;
        private System.Windows.Forms.Label label3;
    }
}