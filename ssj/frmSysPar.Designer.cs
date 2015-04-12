namespace ssj
{
    partial class frmSysPar
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWorFluPre = new System.Windows.Forms.Label();
            this.labelEjeFluPre = new System.Windows.Forms.Label();
            this.labelEjeFluFlo = new System.Windows.Forms.Label();
            this.labelMixFluPre = new System.Windows.Forms.Label();
            this.labelAtm = new System.Windows.Forms.Label();
            this.labelNozCoe = new System.Windows.Forms.Label();
            this.labelThrCoe = new System.Windows.Forms.Label();
            this.labelDifCoe = new System.Windows.Forms.Label();
            this.labelThrEntCoe = new System.Windows.Forms.Label();
            this.textBoxWorkFluPre = new System.Windows.Forms.TextBox();
            this.textBoxEjeFluPre = new System.Windows.Forms.TextBox();
            this.textBoxEjeFluFlo = new System.Windows.Forms.TextBox();
            this.textBoxMixFluPre = new System.Windows.Forms.TextBox();
            this.textBoxAtm = new System.Windows.Forms.TextBox();
            this.textBoxNozCoe = new System.Windows.Forms.TextBox();
            this.textBoxThrCoe = new System.Windows.Forms.TextBox();
            this.textBoxDifCoe = new System.Windows.Forms.TextBox();
            this.textBoxThrEntCoe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaterialType = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWorFluPre
            // 
            this.labelWorFluPre.AutoSize = true;
            this.labelWorFluPre.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWorFluPre.Location = new System.Drawing.Point(23, 54);
            this.labelWorFluPre.Name = "labelWorFluPre";
            this.labelWorFluPre.Size = new System.Drawing.Size(125, 12);
            this.labelWorFluPre.TabIndex = 0;
            this.labelWorFluPre.Text = "工作流体压力（Pp）：";
            // 
            // labelEjeFluPre
            // 
            this.labelEjeFluPre.AutoSize = true;
            this.labelEjeFluPre.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEjeFluPre.Location = new System.Drawing.Point(23, 90);
            this.labelEjeFluPre.Name = "labelEjeFluPre";
            this.labelEjeFluPre.Size = new System.Drawing.Size(125, 12);
            this.labelEjeFluPre.TabIndex = 1;
            this.labelEjeFluPre.Text = "引射流体压力（Ph）：";
            // 
            // labelEjeFluFlo
            // 
            this.labelEjeFluFlo.AutoSize = true;
            this.labelEjeFluFlo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEjeFluFlo.Location = new System.Drawing.Point(23, 123);
            this.labelEjeFluFlo.Name = "labelEjeFluFlo";
            this.labelEjeFluFlo.Size = new System.Drawing.Size(125, 12);
            this.labelEjeFluFlo.TabIndex = 2;
            this.labelEjeFluFlo.Text = "引射流体流量（Qh）：";
            // 
            // labelMixFluPre
            // 
            this.labelMixFluPre.AutoSize = true;
            this.labelMixFluPre.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMixFluPre.Location = new System.Drawing.Point(23, 153);
            this.labelMixFluPre.Name = "labelMixFluPre";
            this.labelMixFluPre.Size = new System.Drawing.Size(137, 12);
            this.labelMixFluPre.TabIndex = 3;
            this.labelMixFluPre.Text = "混合流体压力（Pcjs）：";
            // 
            // labelAtm
            // 
            this.labelAtm.AutoSize = true;
            this.labelAtm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAtm.Location = new System.Drawing.Point(23, 188);
            this.labelAtm.Name = "labelAtm";
            this.labelAtm.Size = new System.Drawing.Size(131, 12);
            this.labelAtm.TabIndex = 4;
            this.labelAtm.Text = "当地大气压力（atm）：";
            // 
            // labelNozCoe
            // 
            this.labelNozCoe.AutoSize = true;
            this.labelNozCoe.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNozCoe.Location = new System.Drawing.Point(23, 218);
            this.labelNozCoe.Name = "labelNozCoe";
            this.labelNozCoe.Size = new System.Drawing.Size(131, 12);
            this.labelNozCoe.TabIndex = 5;
            this.labelNozCoe.Text = "喷嘴流速系数（ψ1）：";
            // 
            // labelThrCoe
            // 
            this.labelThrCoe.AutoSize = true;
            this.labelThrCoe.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelThrCoe.Location = new System.Drawing.Point(23, 256);
            this.labelThrCoe.Name = "labelThrCoe";
            this.labelThrCoe.Size = new System.Drawing.Size(131, 12);
            this.labelThrCoe.TabIndex = 6;
            this.labelThrCoe.Text = "喉管流速系数（ψ2）：";
            // 
            // labelDifCoe
            // 
            this.labelDifCoe.AutoSize = true;
            this.labelDifCoe.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDifCoe.Location = new System.Drawing.Point(23, 295);
            this.labelDifCoe.Name = "labelDifCoe";
            this.labelDifCoe.Size = new System.Drawing.Size(143, 12);
            this.labelDifCoe.TabIndex = 7;
            this.labelDifCoe.Text = "扩散管流速系数（ψ3）：";
            // 
            // labelThrEntCoe
            // 
            this.labelThrEntCoe.AutoSize = true;
            this.labelThrEntCoe.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelThrEntCoe.Location = new System.Drawing.Point(23, 329);
            this.labelThrEntCoe.Name = "labelThrEntCoe";
            this.labelThrEntCoe.Size = new System.Drawing.Size(167, 12);
            this.labelThrEntCoe.TabIndex = 8;
            this.labelThrEntCoe.Text = "喉管入口处流速系数（ψ4）：";
            // 
            // textBoxWorkFluPre
            // 
            this.textBoxWorkFluPre.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxWorkFluPre.Location = new System.Drawing.Point(200, 51);
            this.textBoxWorkFluPre.Name = "textBoxWorkFluPre";
            this.textBoxWorkFluPre.Size = new System.Drawing.Size(100, 21);
            this.textBoxWorkFluPre.TabIndex = 9;
            this.textBoxWorkFluPre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWorkFluPre_KeyPress);
            // 
            // textBoxEjeFluPre
            // 
            this.textBoxEjeFluPre.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxEjeFluPre.Location = new System.Drawing.Point(200, 81);
            this.textBoxEjeFluPre.Name = "textBoxEjeFluPre";
            this.textBoxEjeFluPre.Size = new System.Drawing.Size(100, 21);
            this.textBoxEjeFluPre.TabIndex = 10;
            //--------------------------this.textBoxEjeFluPre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEjeFluPre_KeyPress);
            // 
            // textBoxEjeFluFlo
            // 
            this.textBoxEjeFluFlo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxEjeFluFlo.Location = new System.Drawing.Point(200, 114);
            this.textBoxEjeFluFlo.Name = "textBoxEjeFluFlo";
            this.textBoxEjeFluFlo.Size = new System.Drawing.Size(100, 21);
            this.textBoxEjeFluFlo.TabIndex = 11;
            this.textBoxEjeFluFlo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEjeFluFlo_KeyPress);
            // 
            // textBoxMixFluPre
            // 
            this.textBoxMixFluPre.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxMixFluPre.Location = new System.Drawing.Point(200, 144);
            this.textBoxMixFluPre.Name = "textBoxMixFluPre";
            this.textBoxMixFluPre.Size = new System.Drawing.Size(100, 21);
            this.textBoxMixFluPre.TabIndex = 12;
            this.textBoxMixFluPre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMixFluPre_KeyPress);
            // 
            // textBoxAtm
            // 
            this.textBoxAtm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAtm.Location = new System.Drawing.Point(200, 179);
            this.textBoxAtm.Name = "textBoxAtm";
            this.textBoxAtm.Size = new System.Drawing.Size(100, 21);
            this.textBoxAtm.TabIndex = 13;
            this.textBoxAtm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAtm_KeyPress);
            // 
            // textBoxNozCoe
            // 
            this.textBoxNozCoe.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxNozCoe.Location = new System.Drawing.Point(200, 208);
            this.textBoxNozCoe.Name = "textBoxNozCoe";
            this.textBoxNozCoe.Size = new System.Drawing.Size(100, 21);
            this.textBoxNozCoe.TabIndex = 14;
            this.textBoxNozCoe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNozCoe_KeyPress);
            // 
            // textBoxThrCoe
            // 
            this.textBoxThrCoe.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxThrCoe.Location = new System.Drawing.Point(200, 246);
            this.textBoxThrCoe.Name = "textBoxThrCoe";
            this.textBoxThrCoe.Size = new System.Drawing.Size(100, 21);
            this.textBoxThrCoe.TabIndex = 15;
            this.textBoxThrCoe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxThrCoe_KeyPress);
            // 
            // textBoxDifCoe
            // 
            this.textBoxDifCoe.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxDifCoe.Location = new System.Drawing.Point(200, 285);
            this.textBoxDifCoe.Name = "textBoxDifCoe";
            this.textBoxDifCoe.Size = new System.Drawing.Size(100, 21);
            this.textBoxDifCoe.TabIndex = 16;
            this.textBoxDifCoe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDifCoe_KeyPress);
            // 
            // textBoxThrEntCoe
            // 
            this.textBoxThrEntCoe.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxThrEntCoe.Location = new System.Drawing.Point(200, 326);
            this.textBoxThrEntCoe.Name = "textBoxThrEntCoe";
            this.textBoxThrEntCoe.Size = new System.Drawing.Size(100, 21);
            this.textBoxThrEntCoe.TabIndex = 17;
            this.textBoxThrEntCoe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxThrEntCoe_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(353, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "MPa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(353, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "MPa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(353, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 20;
            this.label12.Text = "kg/h";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(353, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 21;
            this.label13.Text = "MPa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(353, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 12);
            this.label14.TabIndex = 22;
            this.label14.Text = "Mpa";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(380, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "下一步&n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelEjeFluPre);
            this.groupBox1.Controls.Add(this.labelWorFluPre);
            this.groupBox1.Controls.Add(this.labelEjeFluFlo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.labelMixFluPre);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.labelAtm);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.labelNozCoe);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.labelThrCoe);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.labelDifCoe);
            this.groupBox1.Controls.Add(this.textBoxThrEntCoe);
            this.groupBox1.Controls.Add(this.labelThrEntCoe);
            this.groupBox1.Controls.Add(this.textBoxDifCoe);
            this.groupBox1.Controls.Add(this.textBoxWorkFluPre);
            this.groupBox1.Controls.Add(this.textBoxThrCoe);
            this.groupBox1.Controls.Add(this.textBoxEjeFluPre);
            this.groupBox1.Controls.Add(this.textBoxNozCoe);
            this.groupBox1.Controls.Add(this.textBoxEjeFluFlo);
            this.groupBox1.Controls.Add(this.textBoxAtm);
            this.groupBox1.Controls.Add(this.textBoxMixFluPre);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(25, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 393);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "系统设计参数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "介质类别：";
            // 
            // cmbMaterialType
            // 
            this.cmbMaterialType.DisplayMember = "MATERIAL_NAME";
            this.cmbMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterialType.Location = new System.Drawing.Point(204, 26);
            this.cmbMaterialType.Name = "cmbMaterialType";
            this.cmbMaterialType.Size = new System.Drawing.Size(121, 20);
            this.cmbMaterialType.TabIndex = 0;
            this.cmbMaterialType.ValueMember = "MATERIAL_NAME";
            // 
            // frmSysPar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 523);
            this.Controls.Add(this.cmbMaterialType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "frmSysPar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "蒸汽喷射器设计软件";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWorFluPre;
        private System.Windows.Forms.Label labelEjeFluPre;
        private System.Windows.Forms.Label labelEjeFluFlo;
        private System.Windows.Forms.Label labelMixFluPre;
        private System.Windows.Forms.Label labelAtm;
        private System.Windows.Forms.Label labelNozCoe;
        private System.Windows.Forms.Label labelThrCoe;
        private System.Windows.Forms.Label labelDifCoe;
        private System.Windows.Forms.Label labelThrEntCoe;
        private System.Windows.Forms.TextBox textBoxWorkFluPre;
        private System.Windows.Forms.TextBox textBoxEjeFluPre;
        private System.Windows.Forms.TextBox textBoxEjeFluFlo;
        private System.Windows.Forms.TextBox textBoxMixFluPre;
        private System.Windows.Forms.TextBox textBoxAtm;
        private System.Windows.Forms.TextBox textBoxNozCoe;
        private System.Windows.Forms.TextBox textBoxThrCoe;
        private System.Windows.Forms.TextBox textBoxDifCoe;
        private System.Windows.Forms.TextBox textBoxThrEntCoe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaterialType;

    }
}

