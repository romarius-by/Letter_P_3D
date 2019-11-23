namespace _3d_IK
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEdges = new System.Windows.Forms.TabPage();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.tabFaces = new System.Windows.Forms.TabPage();
            this.buttonScale = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.textBoxScaleZ = new System.Windows.Forms.TextBox();
            this.textBoxScaleY = new System.Windows.Forms.TextBox();
            this.textBoxScaleX = new System.Windows.Forms.TextBox();
            this.textBoxMoveZ = new System.Windows.Forms.TextBox();
            this.textBoxMoveY = new System.Windows.Forms.TextBox();
            this.textBoxMoveX = new System.Windows.Forms.TextBox();
            this.textBoxRotateZ = new System.Windows.Forms.TextBox();
            this.textBoxRotateY = new System.Windows.Forms.TextBox();
            this.textBoxRotateX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabProjections = new System.Windows.Forms.TabPage();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.radioButtonProfile = new System.Windows.Forms.RadioButton();
            this.radioButtonHorizontal = new System.Windows.Forms.RadioButton();
            this.radioButtonFrontal = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.radioButtonPerspective = new System.Windows.Forms.RadioButton();
            this.textBoxRo = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxEpsilon = new System.Windows.Forms.TextBox();
            this.textBoxFi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.radioButtonAxonometric = new System.Windows.Forms.RadioButton();
            this.textBoxPsi = new System.Windows.Forms.TextBox();
            this.textBoxFiAx = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.radioButtonOblique = new System.Windows.Forms.RadioButton();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabEdges.SuspendLayout();
            this.tabFaces.SuspendLayout();
            this.tabProjections.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(348, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(532, 466);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEdges);
            this.tabControl1.Controls.Add(this.tabFaces);
            this.tabControl1.Controls.Add(this.tabProjections);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 308);
            this.tabControl1.TabIndex = 1;
            // 
            // tabEdges
            // 
            this.tabEdges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabEdges.Controls.Add(this.textBoxH);
            this.tabEdges.Controls.Add(this.textBoxC);
            this.tabEdges.Controls.Add(this.textBoxB);
            this.tabEdges.Controls.Add(this.textBoxA);
            this.tabEdges.Controls.Add(this.label4);
            this.tabEdges.Controls.Add(this.label3);
            this.tabEdges.Controls.Add(this.label2);
            this.tabEdges.Controls.Add(this.label1);
            this.tabEdges.Controls.Add(this.buttonApply);
            this.tabEdges.Location = new System.Drawing.Point(4, 25);
            this.tabEdges.Name = "tabEdges";
            this.tabEdges.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdges.Size = new System.Drawing.Size(328, 279);
            this.tabEdges.TabIndex = 0;
            this.tabEdges.Text = "Edges";
            this.tabEdges.UseVisualStyleBackColor = true;
            // 
            // textBoxH
            // 
            this.textBoxH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxH.Location = new System.Drawing.Point(57, 172);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 22);
            this.textBoxH.TabIndex = 8;
            this.textBoxH.Text = "120";
            this.textBoxH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxC
            // 
            this.textBoxC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxC.Location = new System.Drawing.Point(57, 122);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 22);
            this.textBoxC.TabIndex = 7;
            this.textBoxC.Text = "100";
            this.textBoxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxB
            // 
            this.textBoxB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxB.Location = new System.Drawing.Point(57, 73);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 6;
            this.textBoxB.Text = "20";
            this.textBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxA
            // 
            this.textBoxA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxA.Location = new System.Drawing.Point(57, 25);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 5;
            this.textBoxA.Text = "30";
            this.textBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "H";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "C";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "B";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(13, 216);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(10);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(300, 48);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // tabFaces
            // 
            this.tabFaces.Controls.Add(this.buttonScale);
            this.tabFaces.Controls.Add(this.buttonMove);
            this.tabFaces.Controls.Add(this.buttonRotate);
            this.tabFaces.Controls.Add(this.textBoxScaleZ);
            this.tabFaces.Controls.Add(this.textBoxScaleY);
            this.tabFaces.Controls.Add(this.textBoxScaleX);
            this.tabFaces.Controls.Add(this.textBoxMoveZ);
            this.tabFaces.Controls.Add(this.textBoxMoveY);
            this.tabFaces.Controls.Add(this.textBoxMoveX);
            this.tabFaces.Controls.Add(this.textBoxRotateZ);
            this.tabFaces.Controls.Add(this.textBoxRotateY);
            this.tabFaces.Controls.Add(this.textBoxRotateX);
            this.tabFaces.Controls.Add(this.label10);
            this.tabFaces.Controls.Add(this.label9);
            this.tabFaces.Controls.Add(this.label8);
            this.tabFaces.Controls.Add(this.label7);
            this.tabFaces.Controls.Add(this.label6);
            this.tabFaces.Controls.Add(this.label5);
            this.tabFaces.Location = new System.Drawing.Point(4, 25);
            this.tabFaces.Name = "tabFaces";
            this.tabFaces.Padding = new System.Windows.Forms.Padding(3);
            this.tabFaces.Size = new System.Drawing.Size(328, 279);
            this.tabFaces.TabIndex = 1;
            this.tabFaces.Text = "Faces";
            this.tabFaces.UseVisualStyleBackColor = true;
            // 
            // buttonScale
            // 
            this.buttonScale.Location = new System.Drawing.Point(210, 162);
            this.buttonScale.Margin = new System.Windows.Forms.Padding(10);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(76, 34);
            this.buttonScale.TabIndex = 20;
            this.buttonScale.Text = "Scale";
            this.buttonScale.UseVisualStyleBackColor = true;
            this.buttonScale.Click += new System.EventHandler(this.buttonScale_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(130, 162);
            this.buttonMove.Margin = new System.Windows.Forms.Padding(10);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(76, 34);
            this.buttonMove.TabIndex = 19;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(47, 162);
            this.buttonRotate.Margin = new System.Windows.Forms.Padding(10);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(76, 34);
            this.buttonRotate.TabIndex = 18;
            this.buttonRotate.Text = "Rotate";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // textBoxScaleZ
            // 
            this.textBoxScaleZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxScaleZ.Location = new System.Drawing.Point(211, 127);
            this.textBoxScaleZ.Name = "textBoxScaleZ";
            this.textBoxScaleZ.Size = new System.Drawing.Size(75, 22);
            this.textBoxScaleZ.TabIndex = 17;
            this.textBoxScaleZ.Text = "1";
            this.textBoxScaleZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxScaleY
            // 
            this.textBoxScaleY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxScaleY.Location = new System.Drawing.Point(211, 85);
            this.textBoxScaleY.Name = "textBoxScaleY";
            this.textBoxScaleY.Size = new System.Drawing.Size(75, 22);
            this.textBoxScaleY.TabIndex = 16;
            this.textBoxScaleY.Text = "1";
            this.textBoxScaleY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxScaleX
            // 
            this.textBoxScaleX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxScaleX.Location = new System.Drawing.Point(211, 44);
            this.textBoxScaleX.Name = "textBoxScaleX";
            this.textBoxScaleX.Size = new System.Drawing.Size(75, 22);
            this.textBoxScaleX.TabIndex = 15;
            this.textBoxScaleX.Text = "1";
            this.textBoxScaleX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMoveZ
            // 
            this.textBoxMoveZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxMoveZ.Location = new System.Drawing.Point(129, 127);
            this.textBoxMoveZ.Name = "textBoxMoveZ";
            this.textBoxMoveZ.Size = new System.Drawing.Size(75, 22);
            this.textBoxMoveZ.TabIndex = 14;
            this.textBoxMoveZ.Text = "0";
            this.textBoxMoveZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMoveY
            // 
            this.textBoxMoveY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxMoveY.Location = new System.Drawing.Point(129, 85);
            this.textBoxMoveY.Name = "textBoxMoveY";
            this.textBoxMoveY.Size = new System.Drawing.Size(75, 22);
            this.textBoxMoveY.TabIndex = 13;
            this.textBoxMoveY.Text = "0";
            this.textBoxMoveY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMoveX
            // 
            this.textBoxMoveX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxMoveX.Location = new System.Drawing.Point(130, 44);
            this.textBoxMoveX.Name = "textBoxMoveX";
            this.textBoxMoveX.Size = new System.Drawing.Size(75, 22);
            this.textBoxMoveX.TabIndex = 12;
            this.textBoxMoveX.Text = "0";
            this.textBoxMoveX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRotateZ
            // 
            this.textBoxRotateZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxRotateZ.Location = new System.Drawing.Point(47, 127);
            this.textBoxRotateZ.Name = "textBoxRotateZ";
            this.textBoxRotateZ.Size = new System.Drawing.Size(75, 22);
            this.textBoxRotateZ.TabIndex = 11;
            this.textBoxRotateZ.Text = "0";
            this.textBoxRotateZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRotateY
            // 
            this.textBoxRotateY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxRotateY.Location = new System.Drawing.Point(48, 85);
            this.textBoxRotateY.Name = "textBoxRotateY";
            this.textBoxRotateY.Size = new System.Drawing.Size(75, 22);
            this.textBoxRotateY.TabIndex = 10;
            this.textBoxRotateY.Text = "0";
            this.textBoxRotateY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRotateX
            // 
            this.textBoxRotateX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxRotateX.Location = new System.Drawing.Point(49, 44);
            this.textBoxRotateX.Name = "textBoxRotateX";
            this.textBoxRotateX.Size = new System.Drawing.Size(75, 22);
            this.textBoxRotateX.TabIndex = 9;
            this.textBoxRotateX.Text = "0";
            this.textBoxRotateX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(215, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Scale";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(138, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Move";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(48, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Rotate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "X";
            // 
            // tabProjections
            // 
            this.tabProjections.Controls.Add(this.label18);
            this.tabProjections.Controls.Add(this.label17);
            this.tabProjections.Controls.Add(this.textBoxL);
            this.tabProjections.Controls.Add(this.textBoxAlpha);
            this.tabProjections.Controls.Add(this.radioButtonOblique);
            this.tabProjections.Controls.Add(this.label16);
            this.tabProjections.Controls.Add(this.label15);
            this.tabProjections.Controls.Add(this.textBoxFiAx);
            this.tabProjections.Controls.Add(this.textBoxPsi);
            this.tabProjections.Controls.Add(this.radioButtonAxonometric);
            this.tabProjections.Controls.Add(this.label14);
            this.tabProjections.Controls.Add(this.label13);
            this.tabProjections.Controls.Add(this.label12);
            this.tabProjections.Controls.Add(this.label11);
            this.tabProjections.Controls.Add(this.textBoxFi);
            this.tabProjections.Controls.Add(this.textBoxEpsilon);
            this.tabProjections.Controls.Add(this.textBoxD);
            this.tabProjections.Controls.Add(this.textBoxRo);
            this.tabProjections.Controls.Add(this.radioButtonPerspective);
            this.tabProjections.Controls.Add(this.buttonRefresh);
            this.tabProjections.Controls.Add(this.radioButtonProfile);
            this.tabProjections.Controls.Add(this.radioButtonHorizontal);
            this.tabProjections.Controls.Add(this.radioButtonFrontal);
            this.tabProjections.Location = new System.Drawing.Point(4, 25);
            this.tabProjections.Name = "tabProjections";
            this.tabProjections.Size = new System.Drawing.Size(328, 279);
            this.tabProjections.TabIndex = 2;
            this.tabProjections.Text = "Projections";
            this.tabProjections.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(17, 232);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(292, 44);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // radioButtonProfile
            // 
            this.radioButtonProfile.AutoSize = true;
            this.radioButtonProfile.Location = new System.Drawing.Point(116, 19);
            this.radioButtonProfile.Name = "radioButtonProfile";
            this.radioButtonProfile.Size = new System.Drawing.Size(69, 21);
            this.radioButtonProfile.TabIndex = 2;
            this.radioButtonProfile.Text = "Profile";
            this.radioButtonProfile.UseVisualStyleBackColor = true;
            this.radioButtonProfile.CheckedChanged += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // radioButtonHorizontal
            // 
            this.radioButtonHorizontal.AutoSize = true;
            this.radioButtonHorizontal.Location = new System.Drawing.Point(210, 19);
            this.radioButtonHorizontal.Name = "radioButtonHorizontal";
            this.radioButtonHorizontal.Size = new System.Drawing.Size(93, 21);
            this.radioButtonHorizontal.TabIndex = 1;
            this.radioButtonHorizontal.Text = "Horizontal";
            this.radioButtonHorizontal.UseVisualStyleBackColor = true;
            this.radioButtonHorizontal.CheckedChanged += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // radioButtonFrontal
            // 
            this.radioButtonFrontal.AutoSize = true;
            this.radioButtonFrontal.Checked = true;
            this.radioButtonFrontal.Location = new System.Drawing.Point(17, 19);
            this.radioButtonFrontal.Name = "radioButtonFrontal";
            this.radioButtonFrontal.Size = new System.Drawing.Size(73, 21);
            this.radioButtonFrontal.TabIndex = 0;
            this.radioButtonFrontal.TabStop = true;
            this.radioButtonFrontal.Text = "Frontal";
            this.radioButtonFrontal.UseVisualStyleBackColor = true;
            this.radioButtonFrontal.CheckedChanged += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(328, 279);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // radioButtonPerspective
            // 
            this.radioButtonPerspective.AutoSize = true;
            this.radioButtonPerspective.Location = new System.Drawing.Point(17, 46);
            this.radioButtonPerspective.Name = "radioButtonPerspective";
            this.radioButtonPerspective.Size = new System.Drawing.Size(103, 21);
            this.radioButtonPerspective.TabIndex = 4;
            this.radioButtonPerspective.Text = "Perspective";
            this.radioButtonPerspective.UseVisualStyleBackColor = true;
            this.radioButtonPerspective.CheckedChanged += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxRo
            // 
            this.textBoxRo.Location = new System.Drawing.Point(29, 73);
            this.textBoxRo.Name = "textBoxRo";
            this.textBoxRo.Size = new System.Drawing.Size(41, 22);
            this.textBoxRo.TabIndex = 5;
            this.textBoxRo.Text = "400";
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(102, 73);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(41, 22);
            this.textBoxD.TabIndex = 6;
            this.textBoxD.Text = "300";
            // 
            // textBoxEpsilon
            // 
            this.textBoxEpsilon.Location = new System.Drawing.Point(179, 73);
            this.textBoxEpsilon.Name = "textBoxEpsilon";
            this.textBoxEpsilon.Size = new System.Drawing.Size(41, 22);
            this.textBoxEpsilon.TabIndex = 7;
            this.textBoxEpsilon.Text = "30";
            // 
            // textBoxFi
            // 
            this.textBoxFi.Location = new System.Drawing.Point(253, 73);
            this.textBoxFi.Name = "textBoxFi";
            this.textBoxFi.Size = new System.Drawing.Size(41, 22);
            this.textBoxFi.TabIndex = 8;
            this.textBoxFi.Text = "-120";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "ρ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "d";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(152, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "θ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(226, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "φ";
            // 
            // radioButtonAxonometric
            // 
            this.radioButtonAxonometric.AutoSize = true;
            this.radioButtonAxonometric.Location = new System.Drawing.Point(17, 113);
            this.radioButtonAxonometric.Name = "radioButtonAxonometric";
            this.radioButtonAxonometric.Size = new System.Drawing.Size(106, 21);
            this.radioButtonAxonometric.TabIndex = 13;
            this.radioButtonAxonometric.Text = "Axonometric";
            this.radioButtonAxonometric.UseVisualStyleBackColor = true;
            this.radioButtonAxonometric.CheckedChanged += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxPsi
            // 
            this.textBoxPsi.Location = new System.Drawing.Point(29, 140);
            this.textBoxPsi.Name = "textBoxPsi";
            this.textBoxPsi.Size = new System.Drawing.Size(41, 22);
            this.textBoxPsi.TabIndex = 14;
            this.textBoxPsi.Text = "30";
            // 
            // textBoxFiAx
            // 
            this.textBoxFiAx.Location = new System.Drawing.Point(102, 140);
            this.textBoxFiAx.Name = "textBoxFiAx";
            this.textBoxFiAx.Size = new System.Drawing.Size(41, 22);
            this.textBoxFiAx.TabIndex = 15;
            this.textBoxFiAx.Text = "-30";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "ψ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(80, 143);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 17);
            this.label16.TabIndex = 17;
            this.label16.Text = "φ";
            // 
            // radioButtonOblique
            // 
            this.radioButtonOblique.AutoSize = true;
            this.radioButtonOblique.Location = new System.Drawing.Point(17, 183);
            this.radioButtonOblique.Name = "radioButtonOblique";
            this.radioButtonOblique.Size = new System.Drawing.Size(78, 21);
            this.radioButtonOblique.TabIndex = 18;
            this.radioButtonOblique.Text = "Oblique";
            this.radioButtonOblique.UseVisualStyleBackColor = true;
            this.radioButtonOblique.CheckedChanged += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(127, 183);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(41, 22);
            this.textBoxAlpha.TabIndex = 19;
            this.textBoxAlpha.Text = "45";
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(210, 183);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(41, 22);
            this.textBoxL.TabIndex = 20;
            this.textBoxL.Text = "1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(106, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 17);
            this.label17.TabIndex = 21;
            this.label17.Text = "α";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(187, 186);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 17);
            this.label18.TabIndex = 22;
            this.label18.Text = "L";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 490);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabEdges.ResumeLayout(false);
            this.tabEdges.PerformLayout();
            this.tabFaces.ResumeLayout(false);
            this.tabFaces.PerformLayout();
            this.tabProjections.ResumeLayout(false);
            this.tabProjections.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEdges;
        private System.Windows.Forms.TabPage tabFaces;
        private System.Windows.Forms.TabPage tabProjections;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxScaleZ;
        private System.Windows.Forms.TextBox textBoxScaleY;
        private System.Windows.Forms.TextBox textBoxScaleX;
        private System.Windows.Forms.TextBox textBoxMoveZ;
        private System.Windows.Forms.TextBox textBoxMoveY;
        private System.Windows.Forms.TextBox textBoxMoveX;
        private System.Windows.Forms.TextBox textBoxRotateZ;
        private System.Windows.Forms.TextBox textBoxRotateY;
        private System.Windows.Forms.TextBox textBoxRotateX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonScale;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.RadioButton radioButtonProfile;
        private System.Windows.Forms.RadioButton radioButtonHorizontal;
        private System.Windows.Forms.RadioButton radioButtonFrontal;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxFi;
        private System.Windows.Forms.TextBox textBoxEpsilon;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxRo;
        private System.Windows.Forms.RadioButton radioButtonPerspective;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.RadioButton radioButtonOblique;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxFiAx;
        private System.Windows.Forms.TextBox textBoxPsi;
        private System.Windows.Forms.RadioButton radioButtonAxonometric;
    }
}

