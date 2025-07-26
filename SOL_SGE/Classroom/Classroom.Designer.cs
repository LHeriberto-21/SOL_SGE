using System.Windows.Forms;

namespace SOL_SGE.Classroom
{
    public partial class Classroom : Form
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
        //public Classroom()
        //{
        //    InitializeComponent();
        //    SubjectPanel();
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlClassroom = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAsistencias = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBiblioteca = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlClassroom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClassroom
            // 
            this.pnlClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.pnlClassroom.Controls.Add(this.tableLayoutPanel1);
            this.pnlClassroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClassroom.Location = new System.Drawing.Point(0, 0);
            this.pnlClassroom.Name = "pnlClassroom";
            this.pnlClassroom.Size = new System.Drawing.Size(800, 450);
            this.pnlClassroom.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 210);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel7.Controls.Add(this.button3);
            this.panel7.Controls.Add(this.btnAsistencias);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.btnBiblioteca);
            this.panel7.Controls.Add(this.btnEntrar);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 9);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(254, 188);
            this.panel7.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(146, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Grupo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAsistencias
            // 
            this.btnAsistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsistencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsistencias.FlatAppearance.BorderSize = 0;
            this.btnAsistencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsistencias.Location = new System.Drawing.Point(146, 81);
            this.btnAsistencias.Name = "btnAsistencias";
            this.btnAsistencias.Size = new System.Drawing.Size(105, 32);
            this.btnAsistencias.TabIndex = 5;
            this.btnAsistencias.Text = "Asistencias";
            this.btnAsistencias.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(156, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Horarios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(3, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calificaciones";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBiblioteca
            // 
            this.btnBiblioteca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiblioteca.FlatAppearance.BorderSize = 0;
            this.btnBiblioteca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiblioteca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiblioteca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBiblioteca.Location = new System.Drawing.Point(12, 81);
            this.btnBiblioteca.Name = "btnBiblioteca";
            this.btnBiblioteca.Size = new System.Drawing.Size(95, 32);
            this.btnBiblioteca.TabIndex = 2;
            this.btnBiblioteca.Text = "Biblioteca";
            this.btnBiblioteca.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEntrar.Location = new System.Drawing.Point(12, 43);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(95, 32);
            this.btnEntrar.TabIndex = 1;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(94, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materia";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(269, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 210);
            this.panel2.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel8.Controls.Add(this.button4);
            this.panel8.Controls.Add(this.button5);
            this.panel8.Controls.Add(this.button6);
            this.panel8.Controls.Add(this.button7);
            this.panel8.Controls.Add(this.button8);
            this.panel8.Controls.Add(this.button9);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(6, 9);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(254, 188);
            this.panel8.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(146, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 32);
            this.button4.TabIndex = 6;
            this.button4.Text = "Grupo";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(146, 81);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 32);
            this.button5.TabIndex = 5;
            this.button5.Text = "Asistencias";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(156, 43);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 32);
            this.button6.TabIndex = 4;
            this.button6.Text = "Horarios";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(3, 119);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 32);
            this.button7.TabIndex = 3;
            this.button7.Text = "Calificaciones";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(12, 81);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 32);
            this.button8.TabIndex = 2;
            this.button8.Text = "Biblioteca";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(12, 43);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 32);
            this.button9.TabIndex = 1;
            this.button9.Text = "Entrar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(94, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Materia";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 228);
            this.panel3.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel10.Controls.Add(this.button16);
            this.panel10.Controls.Add(this.button17);
            this.panel10.Controls.Add(this.button18);
            this.panel10.Controls.Add(this.button19);
            this.panel10.Controls.Add(this.button20);
            this.panel10.Controls.Add(this.button21);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(3, 17);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(254, 188);
            this.panel10.TabIndex = 7;
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button16.Location = new System.Drawing.Point(146, 119);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(105, 32);
            this.button16.TabIndex = 6;
            this.button16.Text = "Grupo";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button17.Location = new System.Drawing.Point(146, 81);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(105, 32);
            this.button17.TabIndex = 5;
            this.button17.Text = "Asistencias";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button18.Location = new System.Drawing.Point(156, 43);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(95, 32);
            this.button18.TabIndex = 4;
            this.button18.Text = "Horarios";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button19.Location = new System.Drawing.Point(3, 119);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(118, 32);
            this.button19.TabIndex = 3;
            this.button19.Text = "Calificaciones";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button20.Location = new System.Drawing.Point(12, 81);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(95, 32);
            this.button20.TabIndex = 2;
            this.button20.Text = "Biblioteca";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button21.Location = new System.Drawing.Point(12, 43);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(95, 32);
            this.button21.TabIndex = 1;
            this.button21.Text = "Entrar";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(94, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Materia";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(269, 219);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 228);
            this.panel4.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel11.Controls.Add(this.button22);
            this.panel11.Controls.Add(this.button23);
            this.panel11.Controls.Add(this.button24);
            this.panel11.Controls.Add(this.button25);
            this.panel11.Controls.Add(this.button26);
            this.panel11.Controls.Add(this.button27);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Location = new System.Drawing.Point(3, 20);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(254, 188);
            this.panel11.TabIndex = 1;
            // 
            // button22
            // 
            this.button22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button22.Location = new System.Drawing.Point(146, 119);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(105, 32);
            this.button22.TabIndex = 6;
            this.button22.Text = "Grupo";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button23.Location = new System.Drawing.Point(146, 81);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(105, 32);
            this.button23.TabIndex = 5;
            this.button23.Text = "Asistencias";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button24.Location = new System.Drawing.Point(156, 43);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(95, 32);
            this.button24.TabIndex = 4;
            this.button24.Text = "Horarios";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button25.Location = new System.Drawing.Point(3, 119);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(118, 32);
            this.button25.TabIndex = 3;
            this.button25.Text = "Calificaciones";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button26.FlatAppearance.BorderSize = 0;
            this.button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button26.Location = new System.Drawing.Point(12, 81);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(95, 32);
            this.button26.TabIndex = 2;
            this.button26.Text = "Biblioteca";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button27.FlatAppearance.BorderSize = 0;
            this.button27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button27.Location = new System.Drawing.Point(12, 43);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(95, 32);
            this.button27.TabIndex = 1;
            this.button27.Text = "Entrar";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(94, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Materia";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(535, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 210);
            this.panel5.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel9.Controls.Add(this.button10);
            this.panel9.Controls.Add(this.button11);
            this.panel9.Controls.Add(this.button12);
            this.panel9.Controls.Add(this.button13);
            this.panel9.Controls.Add(this.button14);
            this.panel9.Controls.Add(this.button15);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(8, 9);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(254, 188);
            this.panel9.TabIndex = 7;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(146, 119);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(105, 32);
            this.button10.TabIndex = 6;
            this.button10.Text = "Grupo";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(146, 81);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(105, 32);
            this.button11.TabIndex = 5;
            this.button11.Text = "Asistencias";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12.Location = new System.Drawing.Point(156, 43);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(95, 32);
            this.button12.TabIndex = 4;
            this.button12.Text = "Horarios";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Location = new System.Drawing.Point(3, 119);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(118, 32);
            this.button13.TabIndex = 3;
            this.button13.Text = "Calificaciones";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button14.Location = new System.Drawing.Point(12, 81);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(95, 32);
            this.button14.TabIndex = 2;
            this.button14.Text = "Biblioteca";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button15.Location = new System.Drawing.Point(12, 43);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(95, 32);
            this.button15.TabIndex = 1;
            this.button15.Text = "Entrar";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(94, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Materia";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel6.Controls.Add(this.panel12);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(535, 219);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 228);
            this.panel6.TabIndex = 5;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel12.Controls.Add(this.button28);
            this.panel12.Controls.Add(this.button29);
            this.panel12.Controls.Add(this.button30);
            this.panel12.Controls.Add(this.button31);
            this.panel12.Controls.Add(this.button32);
            this.panel12.Controls.Add(this.button33);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Location = new System.Drawing.Point(4, 20);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(254, 188);
            this.panel12.TabIndex = 1;
            // 
            // button28
            // 
            this.button28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button28.FlatAppearance.BorderSize = 0;
            this.button28.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button28.Location = new System.Drawing.Point(146, 119);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(105, 32);
            this.button28.TabIndex = 6;
            this.button28.Text = "Grupo";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button29.FlatAppearance.BorderSize = 0;
            this.button29.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button29.Location = new System.Drawing.Point(146, 81);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(105, 32);
            this.button29.TabIndex = 5;
            this.button29.Text = "Asistencias";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button30.FlatAppearance.BorderSize = 0;
            this.button30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button30.Location = new System.Drawing.Point(156, 43);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(95, 32);
            this.button30.TabIndex = 4;
            this.button30.Text = "Horarios";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button31.FlatAppearance.BorderSize = 0;
            this.button31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button31.Location = new System.Drawing.Point(7, 119);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(118, 32);
            this.button31.TabIndex = 3;
            this.button31.Text = "Calificaciones";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button32.FlatAppearance.BorderSize = 0;
            this.button32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button32.Location = new System.Drawing.Point(12, 81);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(95, 32);
            this.button32.TabIndex = 2;
            this.button32.Text = "Biblioteca";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button33.FlatAppearance.BorderSize = 0;
            this.button33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button33.Location = new System.Drawing.Point(12, 43);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(95, 32);
            this.button33.TabIndex = 1;
            this.button33.Text = "Entrar";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(94, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Materia";
            // 
            // Classroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlClassroom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Classroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Classroom";
            this.pnlClassroom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Panel pnlClassroom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private Panel panel7;
        private Button btnEntrar;
        private Label label1;
        private Button button2;
        private Button button1;
        private Button btnBiblioteca;
        private Button btnAsistencias;
        private Button button3;
        private Panel panel8;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label2;
        private Panel panel10;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Label label4;
        private Panel panel11;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
        private Label label5;
        private Panel panel9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Label label3;
        private Panel panel12;
        private Button button28;
        private Button button29;
        private Button button30;
        private Button button31;
        private Button button32;
        private Button button33;
        private Label label6;
    }
}

//this.pnlShowSubjects.SuspendLayout();



//this.btnSchedule = new System.Windows.Forms.Button();
//this.btnRatings = new System.Windows.Forms.Button();

//this.pnlShowSubjects.ResumeLayout(false);
//this.pnlShowSubjects.PerformLayout();
//this.panel1.Controls.Add(this.pnlShowSubjects);


//this.pnlShowSubjects = new System.Windows.Forms.Panel();
//this.btnAssitance = new System.Windows.Forms.Button();
//this.label1 = new System.Windows.Forms.Label();
//this.button2 = new System.Windows.Forms.Button();
//this.button1 = new System.Windows.Forms.Button();
// 
//private System.Windows.Forms.Panel pnlShowSubjects;
//private System.Windows.Forms.Label label1;
//private System.Windows.Forms.Button button2;
//private System.Windows.Forms.Button button1;
//private System.Windows.Forms.Button btnAssitance;
//private System.Windows.Forms.Button btnRatings;
//private System.Windows.Forms.Button btnSchedule;
// pnlShowSubjects
// 
//this.pnlShowSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
//this.pnlShowSubjects.BackColor = System.Drawing.Color.Black
//this.pnlShowSubjects.Controls.Add(this.btnRatings);
//this.pnlShowSubjects.Controls.Add(this.btnSchedule);
//this.pnlShowSubjects.Controls.Add(this.btnAssitance);
//this.pnlShowSubjects.Controls.Add(this.label1);
//this.pnlShowSubjects.Controls.Add(this.button2);
//this.pnlShowSubjects.Controls.Add(this.button1);
//this.pnlShowSubjects.Location = new System.Drawing.Point(6, 9);
//this.pnlShowSubjects.Name = "pnlShowSubjects";
//this.pnlShowSubjects.Size = new System.Drawing.Size(245, 187);
//this.pnlShowSubjects.TabIndex = 0;
// 
// btnAssitance
// 
//this.btnAssitance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
//this.btnAssitance.Cursor = System.Windows.Forms.Cursors.Hand;
//this.btnAssitance.FlatAppearance.BorderSize = 0;
//this.btnAssitance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
//this.btnAssitance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//this.btnAssitance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//this.btnAssitance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
//this.btnAssitance.Location = new System.Drawing.Point(3, 118);
//this.btnAssitance.Name = "btnAssitance";
//this.btnAssitance.Size = new System.Drawing.Size(100, 33);
//this.btnAssitance.TabIndex = 3;
//this.btnAssitance.Text = "Asistencias";
//this.btnAssitance.UseVisualStyleBackColor = true;
// 
// label1
// 
//this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
//this.label1.AutoSize = true;
//this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
//this.label1.Location = new System.Drawing.Point(97, 17);
//this.label1.Name = "label1";
//this.label1.Size = new System.Drawing.Size(62, 20);
//this.label1.TabIndex = 2;
//this.label1.Text = "Materia";
// 
// button2
// 
//this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
//this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
//this.button2.FlatAppearance.BorderSize = 0;
//this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
//this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
//this.button2.Location = new System.Drawing.Point(3, 79);
//this.button2.Name = "button2";
//this.button2.Size = new System.Drawing.Size(100, 33);
//this.button2.TabIndex = 1;
//this.button2.Text = "Biblioteca";
//this.button2.UseVisualStyleBackColor = true;
//// 
// button1
// 
//this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
//this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
//this.button1.FlatAppearance.BorderSize = 0;
//this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
//this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
//this.button1.Location = new System.Drawing.Point(3, 40);
//this.button1.Name = "button1";
//this.button1.Size = new System.Drawing.Size(100, 33);
//this.button1.TabIndex = 0;
//this.button1.Text = "Entrar";
//this.button1.UseVisualStyleBackColor = true;
// 
// panel2
// 

// 
// btnSchedule
// 
//this.btnSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
//this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
//this.btnSchedule.FlatAppearance.BorderSize = 0;
//this.btnSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
//this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//this.btnSchedule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
//this.btnSchedule.Location = new System.Drawing.Point(142, 40);
//this.btnSchedule.Name = "btnSchedule";
//this.btnSchedule.Size = new System.Drawing.Size(100, 33);
//this.btnSchedule.TabIndex = 4;
//this.btnSchedule.Text = "Horario";
//this.btnSchedule.UseVisualStyleBackColor = true;
// 
// btnRatings
// 
//this.btnRatings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
//this.btnRatings.Cursor = System.Windows.Forms.Cursors.Hand;
//this.btnRatings.FlatAppearance.BorderSize = 0;
//this.btnRatings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
//this.btnRatings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//this.btnRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//this.btnRatings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
//this.btnRatings.Location = new System.Drawing.Point(128, 79);
//this.btnRatings.Name = "btnRatings";
//this.btnRatings.Size = new System.Drawing.Size(114, 33);
//this.btnRatings.TabIndex = 5;
//this.btnRatings.Text = "Calificaciones";
//this.btnRatings.UseVisualStyleBackColor = true;