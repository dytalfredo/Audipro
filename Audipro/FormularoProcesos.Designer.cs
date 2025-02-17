/*
 * Created by SharpDevelop.
 * User: dytal
 * Date: 16/2/2025
 * Time: 9:57 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Audipro
{
	partial class FormularoProcesos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label9 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.idtext = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.horasText = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.nombreText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.comboSistema = new System.Windows.Forms.ComboBox();
			this.comboAuditor = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.fechaProceso = new System.Windows.Forms.DateTimePicker();
			this.panel9 = new System.Windows.Forms.Panel();
			this.checkFallas = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.limpiarBtn = new System.Windows.Forms.Button();
			this.todosBtn = new System.Windows.Forms.Button();
			this.registrarBtn = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.fechaFinal = new System.Windows.Forms.DateTimePicker();
			this.fechaInicial = new System.Windows.Forms.DateTimePicker();
			this.filtrarBtn = new System.Windows.Forms.Button();
			this.panelUltimosProcesos = new System.Windows.Forms.Panel();
			this.labelFiltro = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.resultadoText = new System.Windows.Forms.TextBox();
			this.panel8 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panelUltimosProcesos.SuspendLayout();
			this.panel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.83105F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.16895F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
			this.tableLayoutPanel1.Controls.Add(this.label9, 3, 4);
			this.tableLayoutPanel1.Controls.Add(this.panel7, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.panel5, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.fechaProceso, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.panel9, 1, 6);
			this.tableLayoutPanel1.Font = new System.Drawing.Font("Nunito Sans Normal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.36508F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.63492F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(905, 409);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(449, 262);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(315, 33);
			this.label9.TabIndex = 11;
			this.label9.Text = "Resultados";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.label10);
			this.panel7.Controls.Add(this.label6);
			this.panel7.Controls.Add(this.idtext);
			this.panel7.Location = new System.Drawing.Point(103, 225);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(332, 33);
			this.panel7.TabIndex = 4;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Nunito Sans Normal", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(30, 7);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(136, 21);
			this.label10.TabIndex = 11;
			this.label10.Text = "El id es automatico";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(172, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 33);
			this.label6.TabIndex = 10;
			this.label6.Text = "Id";
			// 
			// idtext
			// 
			this.idtext.Location = new System.Drawing.Point(213, 0);
			this.idtext.Name = "idtext";
			this.idtext.ReadOnly = true;
			this.idtext.Size = new System.Drawing.Size(119, 29);
			this.idtext.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.horasText);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Location = new System.Drawing.Point(449, 225);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(315, 33);
			this.panel5.TabIndex = 3;
			// 
			// horasText
			// 
			this.horasText.Location = new System.Drawing.Point(92, 0);
			this.horasText.Name = "horasText";
			this.horasText.Size = new System.Drawing.Size(138, 29);
			this.horasText.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Left;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 33);
			this.label5.TabIndex = 9;
			this.label5.Text = "Horas";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Nunito Sans Normal Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(103, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(275, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Area de Procesos";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.nombreText);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(103, 65);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(332, 154);
			this.panel2.TabIndex = 1;
			// 
			// nombreText
			// 
			this.nombreText.Location = new System.Drawing.Point(3, 31);
			this.nombreText.Multiline = true;
			this.nombreText.Name = "nombreText";
			this.nombreText.Size = new System.Drawing.Size(326, 120);
			this.nombreText.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(332, 28);
			this.label2.TabIndex = 6;
			this.label2.Text = "Descripción del proceso";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.comboSistema);
			this.panel4.Controls.Add(this.comboAuditor);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new System.Drawing.Point(449, 65);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(315, 154);
			this.panel4.TabIndex = 3;
			// 
			// comboSistema
			// 
			this.comboSistema.FormattingEnabled = true;
			this.comboSistema.Location = new System.Drawing.Point(3, 106);
			this.comboSistema.Name = "comboSistema";
			this.comboSistema.Size = new System.Drawing.Size(309, 31);
			this.comboSistema.TabIndex = 9;
			// 
			// comboAuditor
			// 
			this.comboAuditor.FormattingEnabled = true;
			this.comboAuditor.Location = new System.Drawing.Point(3, 31);
			this.comboAuditor.Name = "comboAuditor";
			this.comboAuditor.Size = new System.Drawing.Size(309, 31);
			this.comboAuditor.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(3, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(119, 33);
			this.label8.TabIndex = 8;
			this.label8.Text = "Rif Empresa";
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(315, 28);
			this.label4.TabIndex = 7;
			this.label4.Text = "Cedula del Auditor";
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.label7);
			this.panel6.Location = new System.Drawing.Point(103, 265);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(253, 28);
			this.panel6.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.Dock = System.Windows.Forms.DockStyle.Left;
			this.label7.Location = new System.Drawing.Point(0, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(332, 28);
			this.label7.TabIndex = 10;
			this.label7.Text = "Fecha Del Proceso";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// fechaProceso
			// 
			this.fechaProceso.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fechaProceso.Location = new System.Drawing.Point(103, 299);
			this.fechaProceso.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.fechaProceso.Name = "fechaProceso";
			this.fechaProceso.Size = new System.Drawing.Size(332, 29);
			this.fechaProceso.TabIndex = 4;
			this.fechaProceso.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.checkFallas);
			this.panel9.Location = new System.Drawing.Point(103, 347);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(332, 59);
			this.panel9.TabIndex = 12;
			// 
			// checkFallas
			// 
			this.checkFallas.Location = new System.Drawing.Point(82, 7);
			this.checkFallas.Name = "checkFallas";
			this.checkFallas.Size = new System.Drawing.Size(235, 39);
			this.checkFallas.TabIndex = 13;
			this.checkFallas.Text = "Presenta Fallas";
			this.checkFallas.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.limpiarBtn);
			this.panel1.Controls.Add(this.todosBtn);
			this.panel1.Controls.Add(this.registrarBtn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 503);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1184, 58);
			this.panel1.TabIndex = 1;
			// 
			// limpiarBtn
			// 
			this.limpiarBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.limpiarBtn.AutoSize = true;
			this.limpiarBtn.Font = new System.Drawing.Font("Nunito Sans Normal Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.limpiarBtn.Location = new System.Drawing.Point(310, 6);
			this.limpiarBtn.Name = "limpiarBtn";
			this.limpiarBtn.Size = new System.Drawing.Size(122, 40);
			this.limpiarBtn.TabIndex = 18;
			this.limpiarBtn.Text = "Limpiar";
			this.limpiarBtn.UseVisualStyleBackColor = true;
			this.limpiarBtn.Click += new System.EventHandler(this.LimpiarBtnClick);
			// 
			// todosBtn
			// 
			this.todosBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.todosBtn.AutoSize = true;
			this.todosBtn.Font = new System.Drawing.Font("Nunito Sans Normal Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.todosBtn.Location = new System.Drawing.Point(964, 0);
			this.todosBtn.Name = "todosBtn";
			this.todosBtn.Size = new System.Drawing.Size(194, 40);
			this.todosBtn.TabIndex = 17;
			this.todosBtn.Text = "Mostrar Todos";
			this.todosBtn.UseVisualStyleBackColor = true;
			this.todosBtn.Click += new System.EventHandler(this.TodosBtnClick);
			// 
			// registrarBtn
			// 
			this.registrarBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.registrarBtn.AutoSize = true;
			this.registrarBtn.Font = new System.Drawing.Font("Nunito Sans Normal Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registrarBtn.Location = new System.Drawing.Point(479, 6);
			this.registrarBtn.Name = "registrarBtn";
			this.registrarBtn.Size = new System.Drawing.Size(122, 40);
			this.registrarBtn.TabIndex = 1;
			this.registrarBtn.Text = "Registrar";
			this.registrarBtn.UseVisualStyleBackColor = true;
			this.registrarBtn.Click += new System.EventHandler(this.RegistrarBtnClick);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label13);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.fechaFinal);
			this.panel3.Controls.Add(this.fechaInicial);
			this.panel3.Controls.Add(this.filtrarBtn);
			this.panel3.Controls.Add(this.panelUltimosProcesos);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(911, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(0, 3, 20, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(273, 503);
			this.panel3.TabIndex = 2;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Nunito Sans Normal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(-23, 49);
			this.label13.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(319, 30);
			this.label13.TabIndex = 17;
			this.label13.Text = "Reportes";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Nunito Sans Normal", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(166, 375);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(88, 21);
			this.label12.TabIndex = 16;
			this.label12.Text = "Fecha Final";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Nunito Sans Normal", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(20, 374);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 21);
			this.label11.TabIndex = 15;
			this.label11.Text = "Fecha Inicial";
			// 
			// fechaFinal
			// 
			this.fechaFinal.Location = new System.Drawing.Point(163, 402);
			this.fechaFinal.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.fechaFinal.Name = "fechaFinal";
			this.fechaFinal.Size = new System.Drawing.Size(98, 20);
			this.fechaFinal.TabIndex = 14;
			this.fechaFinal.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			// 
			// fechaInicial
			// 
			this.fechaInicial.Location = new System.Drawing.Point(15, 402);
			this.fechaInicial.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.fechaInicial.Name = "fechaInicial";
			this.fechaInicial.Size = new System.Drawing.Size(98, 20);
			this.fechaInicial.TabIndex = 13;
			this.fechaInicial.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			// 
			// filtrarBtn
			// 
			this.filtrarBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.filtrarBtn.AutoSize = true;
			this.filtrarBtn.Font = new System.Drawing.Font("Nunito Sans Normal Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.filtrarBtn.Location = new System.Drawing.Point(53, 457);
			this.filtrarBtn.Name = "filtrarBtn";
			this.filtrarBtn.Size = new System.Drawing.Size(194, 40);
			this.filtrarBtn.TabIndex = 2;
			this.filtrarBtn.Text = "Filtrar Por Fecha";
			this.filtrarBtn.UseVisualStyleBackColor = true;
			this.filtrarBtn.Click += new System.EventHandler(this.FiltrarBtnClick);
			// 
			// panelUltimosProcesos
			// 
			this.panelUltimosProcesos.AutoScroll = true;
			this.panelUltimosProcesos.Controls.Add(this.labelFiltro);
			this.panelUltimosProcesos.Location = new System.Drawing.Point(3, 121);
			this.panelUltimosProcesos.Name = "panelUltimosProcesos";
			this.panelUltimosProcesos.Size = new System.Drawing.Size(267, 247);
			this.panelUltimosProcesos.TabIndex = 1;
			// 
			// labelFiltro
			// 
			this.labelFiltro.Font = new System.Drawing.Font("Nunito Sans Normal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFiltro.Location = new System.Drawing.Point(17, 214);
			this.labelFiltro.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
			this.labelFiltro.Name = "labelFiltro";
			this.labelFiltro.Size = new System.Drawing.Size(229, 30);
			this.labelFiltro.TabIndex = 18;
			this.labelFiltro.Text = "Filtro Fecha";
			this.labelFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelFiltro.Visible = false;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Nunito Sans Normal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(38, 77);
			this.label3.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(196, 41);
			this.label3.TabIndex = 0;
			this.label3.Text = "Lista de Procesos";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// resultadoText
			// 
			this.resultadoText.Location = new System.Drawing.Point(3, 3);
			this.resultadoText.Multiline = true;
			this.resultadoText.Name = "resultadoText";
			this.resultadoText.Size = new System.Drawing.Size(312, 107);
			this.resultadoText.TabIndex = 8;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.resultadoText);
			this.panel8.Location = new System.Drawing.Point(449, 339);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(315, 110);
			this.panel8.TabIndex = 5;
			// 
			// FormularoProcesos
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1184, 561);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "FormularoProcesos";
			this.Text = "FormularoProcesos";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panelUltimosProcesos.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labelFiltro;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button limpiarBtn;
		private System.Windows.Forms.Button todosBtn;
		private System.Windows.Forms.Button filtrarBtn;
		private System.Windows.Forms.DateTimePicker fechaInicial;
		private System.Windows.Forms.DateTimePicker fechaFinal;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox resultadoText;
		private System.Windows.Forms.CheckBox checkFallas;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboSistema;
		private System.Windows.Forms.ComboBox comboAuditor;
		private System.Windows.Forms.TextBox nombreText;
		private System.Windows.Forms.Panel panelUltimosProcesos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button registrarBtn;
		private System.Windows.Forms.DateTimePicker fechaProceso;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox horasText;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox idtext;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		

		}
	}
