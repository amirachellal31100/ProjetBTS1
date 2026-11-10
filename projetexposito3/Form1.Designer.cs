namespace projetexposito3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ongletutilisateur = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbDeclaration = new System.Windows.Forms.GroupBox();
            this.tabIncidentsutili = new System.Windows.Forms.DataGridView();
            this.numIncident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matériel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gravité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMateriel = new System.Windows.Forms.ComboBox();
            this.lblMateriel = new System.Windows.Forms.Label();
            this.cbGravite = new System.Windows.Forms.ComboBox();
            this.lblGravite = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtNomIncident = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.onglettechnicien = new System.Windows.Forms.TabPage();
            this.gbGestion = new System.Windows.Forms.GroupBox();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnenregincident = new System.Windows.Forms.Button();
            this.listemateriel = new System.Windows.Forms.ListBox();
            this.btnenregmateriel = new System.Windows.Forms.Button();
            this.tbxmateriel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrendreEnCharge = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabincidentech = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ongletresponsable = new System.Windows.Forms.TabPage();
            this.groupeboxutilisateur = new System.Windows.Forms.GroupBox();
            this.boutonmodifierutilisa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.roleutilisateur = new System.Windows.Forms.TextBox();
            this.listeutilisateur = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nomutilisateur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabincidentrespo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajoutehni = new System.Windows.Forms.GroupBox();
            this.boutonmodifiertechni = new System.Windows.Forms.Button();
            this.lqbel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datembauche = new System.Windows.Forms.TextBox();
            this.roletechni = new System.Windows.Forms.TextBox();
            this.listetechnicien = new System.Windows.Forms.ListBox();
            this.btnsupptechni = new System.Windows.Forms.Button();
            this.boutonajoutertechni = new System.Windows.Forms.Button();
            this.nomtechni = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.Label();
            this.lblproprietaire = new System.Windows.Forms.Label();
            this.comboBoxproprietaire = new System.Windows.Forms.ComboBox();
            this.lblnumeromatricul = new System.Windows.Forms.Label();
            this.textBoxnumeromatricul = new System.Windows.Forms.TextBox();
            this.lblmatriculeutisateur = new System.Windows.Forms.Label();
            this.textBoxnumeroutilisateur = new System.Windows.Forms.TextBox();
            this.ongletutilisateur.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbDeclaration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabIncidentsutili)).BeginInit();
            this.onglettechnicien.SuspendLayout();
            this.gbGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabincidentech)).BeginInit();
            this.ongletresponsable.SuspendLayout();
            this.groupeboxutilisateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabincidentrespo)).BeginInit();
            this.ajoutehni.SuspendLayout();
            this.SuspendLayout();
            // 
            // ongletutilisateur
            // 
            this.ongletutilisateur.Controls.Add(this.tabPage1);
            this.ongletutilisateur.Controls.Add(this.onglettechnicien);
            this.ongletutilisateur.Controls.Add(this.ongletresponsable);
            this.ongletutilisateur.Location = new System.Drawing.Point(12, 12);
            this.ongletutilisateur.Name = "ongletutilisateur";
            this.ongletutilisateur.SelectedIndex = 0;
            this.ongletutilisateur.Size = new System.Drawing.Size(765, 462);
            this.ongletutilisateur.TabIndex = 0;
            this.ongletutilisateur.SelectedIndexChanged += new System.EventHandler(this.ongletutilisateur_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbDeclaration);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Utiliateur";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbDeclaration
            // 
            this.gbDeclaration.Controls.Add(this.tabIncidentsutili);
            this.gbDeclaration.Controls.Add(this.cbMateriel);
            this.gbDeclaration.Controls.Add(this.lblMateriel);
            this.gbDeclaration.Controls.Add(this.cbGravite);
            this.gbDeclaration.Controls.Add(this.lblGravite);
            this.gbDeclaration.Controls.Add(this.btnValider);
            this.gbDeclaration.Controls.Add(this.txtNomIncident);
            this.gbDeclaration.Controls.Add(this.lblNom);
            this.gbDeclaration.Location = new System.Drawing.Point(16, 18);
            this.gbDeclaration.Name = "gbDeclaration";
            this.gbDeclaration.Size = new System.Drawing.Size(606, 311);
            this.gbDeclaration.TabIndex = 11;
            this.gbDeclaration.TabStop = false;
            this.gbDeclaration.Text = "Espace Déclaration (Utilisateur)";
            // 
            // tabIncidentsutili
            // 
            this.tabIncidentsutili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabIncidentsutili.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numIncident,
            this.Matériel,
            this.Gravité,
            this.description,
            this.statut});
            this.tabIncidentsutili.Location = new System.Drawing.Point(6, 257);
            this.tabIncidentsutili.Name = "tabIncidentsutili";
            this.tabIncidentsutili.Size = new System.Drawing.Size(506, 84);
            this.tabIncidentsutili.TabIndex = 8;
            // 
            // numIncident
            // 
            this.numIncident.HeaderText = "N° Incident";
            this.numIncident.Name = "numIncident";
            // 
            // Matériel
            // 
            this.Matériel.HeaderText = "Matériel";
            this.Matériel.Name = "Matériel";
            // 
            // Gravité
            // 
            this.Gravité.HeaderText = "Gravité";
            this.Gravité.Name = "Gravité";
            // 
            // description
            // 
            this.description.HeaderText = "description";
            this.description.Name = "description";
            // 
            // statut
            // 
            this.statut.HeaderText = "statut";
            this.statut.Name = "statut";
            // 
            // cbMateriel
            // 
            this.cbMateriel.FormattingEnabled = true;
            this.cbMateriel.Location = new System.Drawing.Point(146, 31);
            this.cbMateriel.Name = "cbMateriel";
            this.cbMateriel.Size = new System.Drawing.Size(121, 21);
            this.cbMateriel.TabIndex = 1;
            // 
            // lblMateriel
            // 
            this.lblMateriel.AutoSize = true;
            this.lblMateriel.Location = new System.Drawing.Point(6, 31);
            this.lblMateriel.Name = "lblMateriel";
            this.lblMateriel.Size = new System.Drawing.Size(122, 13);
            this.lblMateriel.TabIndex = 0;
            this.lblMateriel.Text = "Sélectionner le matériel :";
            // 
            // cbGravite
            // 
            this.cbGravite.FormattingEnabled = true;
            this.cbGravite.Items.AddRange(new object[] {
            "Faible",
            "",
            "Moyenne",
            "",
            "Élevée",
            "",
            "Critique"});
            this.cbGravite.Location = new System.Drawing.Point(146, 79);
            this.cbGravite.Name = "cbGravite";
            this.cbGravite.Size = new System.Drawing.Size(121, 21);
            this.cbGravite.TabIndex = 3;
            // 
            // lblGravite
            // 
            this.lblGravite.AutoSize = true;
            this.lblGravite.Location = new System.Drawing.Point(18, 82);
            this.lblGravite.Name = "lblGravite";
            this.lblGravite.Size = new System.Drawing.Size(106, 13);
            this.lblGravite.TabIndex = 2;
            this.lblGravite.Text = "Gravité de l\'incident :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(90, 192);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(119, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Déclarer l\'incident";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // txtNomIncident
            // 
            this.txtNomIncident.Location = new System.Drawing.Point(167, 144);
            this.txtNomIncident.Name = "txtNomIncident";
            this.txtNomIncident.Size = new System.Drawing.Size(100, 20);
            this.txtNomIncident.TabIndex = 5;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(18, 132);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(94, 13);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom de l\'incident :";
            // 
            // onglettechnicien
            // 
            this.onglettechnicien.Controls.Add(this.gbGestion);
            this.onglettechnicien.Location = new System.Drawing.Point(4, 22);
            this.onglettechnicien.Name = "onglettechnicien";
            this.onglettechnicien.Padding = new System.Windows.Forms.Padding(3);
            this.onglettechnicien.Size = new System.Drawing.Size(757, 436);
            this.onglettechnicien.TabIndex = 1;
            this.onglettechnicien.Text = "Techniciens";
            this.onglettechnicien.UseVisualStyleBackColor = true;
            // 
            // gbGestion
            // 
            this.gbGestion.Controls.Add(this.comboBoxproprietaire);
            this.gbGestion.Controls.Add(this.lblproprietaire);
            this.gbGestion.Controls.Add(this.btnsupprimer);
            this.gbGestion.Controls.Add(this.btnenregincident);
            this.gbGestion.Controls.Add(this.listemateriel);
            this.gbGestion.Controls.Add(this.btnenregmateriel);
            this.gbGestion.Controls.Add(this.tbxmateriel);
            this.gbGestion.Controls.Add(this.label1);
            this.gbGestion.Controls.Add(this.btnPrendreEnCharge);
            this.gbGestion.Controls.Add(this.label2);
            this.gbGestion.Controls.Add(this.tabincidentech);
            this.gbGestion.Location = new System.Drawing.Point(16, 18);
            this.gbGestion.Name = "gbGestion";
            this.gbGestion.Size = new System.Drawing.Size(657, 393);
            this.gbGestion.TabIndex = 13;
            this.gbGestion.TabStop = false;
            this.gbGestion.Text = "Espace Suivi et Prise en charge (Technicien)";
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(151, 198);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnsupprimer.TabIndex = 15;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            // 
            // btnenregincident
            // 
            this.btnenregincident.Location = new System.Drawing.Point(555, 329);
            this.btnenregincident.Name = "btnenregincident";
            this.btnenregincident.Size = new System.Drawing.Size(75, 23);
            this.btnenregincident.TabIndex = 14;
            this.btnenregincident.Text = "enregister";
            this.btnenregincident.UseVisualStyleBackColor = true;
            // 
            // listemateriel
            // 
            this.listemateriel.FormattingEnabled = true;
            this.listemateriel.Location = new System.Drawing.Point(6, 157);
            this.listemateriel.Name = "listemateriel";
            this.listemateriel.Size = new System.Drawing.Size(120, 95);
            this.listemateriel.TabIndex = 13;
            // 
            // btnenregmateriel
            // 
            this.btnenregmateriel.Location = new System.Drawing.Point(18, 118);
            this.btnenregmateriel.Name = "btnenregmateriel";
            this.btnenregmateriel.Size = new System.Drawing.Size(75, 23);
            this.btnenregmateriel.TabIndex = 12;
            this.btnenregmateriel.Text = "Enregistrer un materiel";
            this.btnenregmateriel.UseVisualStyleBackColor = true;
            // 
            // tbxmateriel
            // 
            this.tbxmateriel.Location = new System.Drawing.Point(109, 33);
            this.tbxmateriel.Name = "tbxmateriel";
            this.tbxmateriel.Size = new System.Drawing.Size(100, 20);
            this.tbxmateriel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ajouter un materiel:";
            // 
            // btnPrendreEnCharge
            // 
            this.btnPrendreEnCharge.Location = new System.Drawing.Point(530, 280);
            this.btnPrendreEnCharge.Name = "btnPrendreEnCharge";
            this.btnPrendreEnCharge.Size = new System.Drawing.Size(121, 23);
            this.btnPrendreEnCharge.TabIndex = 9;
            this.btnPrendreEnCharge.Text = "Prendre en charge";
            this.btnPrendreEnCharge.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Historique des incidents déclarés :";
            // 
            // tabincidentech
            // 
            this.tabincidentech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabincidentech.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tabincidentech.Location = new System.Drawing.Point(0, 280);
            this.tabincidentech.Name = "tabincidentech";
            this.tabincidentech.Size = new System.Drawing.Size(506, 88);
            this.tabincidentech.TabIndex = 7;
            this.tabincidentech.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabincident_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "N° Incident";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Matériel";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Gravité";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "statut";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ongletresponsable
            // 
            this.ongletresponsable.Controls.Add(this.groupeboxutilisateur);
            this.ongletresponsable.Controls.Add(this.tabincidentrespo);
            this.ongletresponsable.Controls.Add(this.ajoutehni);
            this.ongletresponsable.Location = new System.Drawing.Point(4, 22);
            this.ongletresponsable.Name = "ongletresponsable";
            this.ongletresponsable.Padding = new System.Windows.Forms.Padding(3);
            this.ongletresponsable.Size = new System.Drawing.Size(757, 436);
            this.ongletresponsable.TabIndex = 2;
            this.ongletresponsable.Text = "Responsable";
            this.ongletresponsable.UseVisualStyleBackColor = true;
            // 
            // groupeboxutilisateur
            // 
            this.groupeboxutilisateur.Controls.Add(this.textBoxnumeroutilisateur);
            this.groupeboxutilisateur.Controls.Add(this.lblmatriculeutisateur);
            this.groupeboxutilisateur.Controls.Add(this.boutonmodifierutilisa);
            this.groupeboxutilisateur.Controls.Add(this.label5);
            this.groupeboxutilisateur.Controls.Add(this.roleutilisateur);
            this.groupeboxutilisateur.Controls.Add(this.listeutilisateur);
            this.groupeboxutilisateur.Controls.Add(this.button1);
            this.groupeboxutilisateur.Controls.Add(this.button2);
            this.groupeboxutilisateur.Controls.Add(this.nomutilisateur);
            this.groupeboxutilisateur.Controls.Add(this.label6);
            this.groupeboxutilisateur.Location = new System.Drawing.Point(361, 19);
            this.groupeboxutilisateur.Name = "groupeboxutilisateur";
            this.groupeboxutilisateur.Size = new System.Drawing.Size(320, 316);
            this.groupeboxutilisateur.TabIndex = 11;
            this.groupeboxutilisateur.TabStop = false;
            this.groupeboxutilisateur.Text = "Utilisateur";
            // 
            // boutonmodifierutilisa
            // 
            this.boutonmodifierutilisa.Location = new System.Drawing.Point(175, 273);
            this.boutonmodifierutilisa.Name = "boutonmodifierutilisa";
            this.boutonmodifierutilisa.Size = new System.Drawing.Size(75, 23);
            this.boutonmodifierutilisa.TabIndex = 13;
            this.boutonmodifierutilisa.Text = "Modifier";
            this.boutonmodifierutilisa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Role";
            // 
            // roleutilisateur
            // 
            this.roleutilisateur.Location = new System.Drawing.Point(67, 97);
            this.roleutilisateur.Name = "roleutilisateur";
            this.roleutilisateur.Size = new System.Drawing.Size(100, 20);
            this.roleutilisateur.TabIndex = 7;
            // 
            // listeutilisateur
            // 
            this.listeutilisateur.FormattingEnabled = true;
            this.listeutilisateur.Location = new System.Drawing.Point(6, 172);
            this.listeutilisateur.Name = "listeutilisateur";
            this.listeutilisateur.Size = new System.Drawing.Size(120, 95);
            this.listeutilisateur.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nomutilisateur
            // 
            this.nomutilisateur.Location = new System.Drawing.Point(67, 24);
            this.nomutilisateur.Name = "nomutilisateur";
            this.nomutilisateur.Size = new System.Drawing.Size(100, 20);
            this.nomutilisateur.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nom";
            // 
            // tabincidentrespo
            // 
            this.tabincidentrespo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabincidentrespo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tabincidentrespo.Location = new System.Drawing.Point(6, 349);
            this.tabincidentrespo.Name = "tabincidentrespo";
            this.tabincidentrespo.Size = new System.Drawing.Size(506, 84);
            this.tabincidentrespo.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "N° Incident";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Matériel";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Gravité";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "description";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "statut";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // ajoutehni
            // 
            this.ajoutehni.Controls.Add(this.textBoxnumeromatricul);
            this.ajoutehni.Controls.Add(this.lblnumeromatricul);
            this.ajoutehni.Controls.Add(this.boutonmodifiertechni);
            this.ajoutehni.Controls.Add(this.lqbel);
            this.ajoutehni.Controls.Add(this.label3);
            this.ajoutehni.Controls.Add(this.datembauche);
            this.ajoutehni.Controls.Add(this.roletechni);
            this.ajoutehni.Controls.Add(this.listetechnicien);
            this.ajoutehni.Controls.Add(this.btnsupptechni);
            this.ajoutehni.Controls.Add(this.boutonajoutertechni);
            this.ajoutehni.Controls.Add(this.nomtechni);
            this.ajoutehni.Controls.Add(this.nom);
            this.ajoutehni.Location = new System.Drawing.Point(6, 19);
            this.ajoutehni.Name = "ajoutehni";
            this.ajoutehni.Size = new System.Drawing.Size(320, 316);
            this.ajoutehni.TabIndex = 1;
            this.ajoutehni.TabStop = false;
            this.ajoutehni.Text = "Techniciens";
            this.ajoutehni.Enter += new System.EventHandler(this.ajoutehni_Enter);
            // 
            // boutonmodifiertechni
            // 
            this.boutonmodifiertechni.Location = new System.Drawing.Point(128, 287);
            this.boutonmodifiertechni.Name = "boutonmodifiertechni";
            this.boutonmodifiertechni.Size = new System.Drawing.Size(75, 23);
            this.boutonmodifiertechni.TabIndex = 12;
            this.boutonmodifiertechni.Text = "Modifier";
            this.boutonmodifiertechni.UseVisualStyleBackColor = true;
            // 
            // lqbel
            // 
            this.lqbel.AutoSize = true;
            this.lqbel.Location = new System.Drawing.Point(3, 131);
            this.lqbel.Name = "lqbel";
            this.lqbel.Size = new System.Drawing.Size(91, 13);
            this.lqbel.TabIndex = 9;
            this.lqbel.Text = "Date d\'embauche";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Role";
            // 
            // datembauche
            // 
            this.datembauche.Location = new System.Drawing.Point(103, 128);
            this.datembauche.Name = "datembauche";
            this.datembauche.Size = new System.Drawing.Size(100, 20);
            this.datembauche.TabIndex = 6;
            // 
            // roletechni
            // 
            this.roletechni.Location = new System.Drawing.Point(67, 90);
            this.roletechni.Name = "roletechni";
            this.roletechni.Size = new System.Drawing.Size(100, 20);
            this.roletechni.TabIndex = 7;
            // 
            // listetechnicien
            // 
            this.listetechnicien.FormattingEnabled = true;
            this.listetechnicien.Location = new System.Drawing.Point(0, 186);
            this.listetechnicien.Name = "listetechnicien";
            this.listetechnicien.Size = new System.Drawing.Size(120, 95);
            this.listetechnicien.TabIndex = 3;
            // 
            // btnsupptechni
            // 
            this.btnsupptechni.Location = new System.Drawing.Point(6, 287);
            this.btnsupptechni.Name = "btnsupptechni";
            this.btnsupptechni.Size = new System.Drawing.Size(75, 23);
            this.btnsupptechni.TabIndex = 4;
            this.btnsupptechni.Text = "Supprimer";
            this.btnsupptechni.UseVisualStyleBackColor = true;
            // 
            // boutonajoutertechni
            // 
            this.boutonajoutertechni.Location = new System.Drawing.Point(178, 186);
            this.boutonajoutertechni.Name = "boutonajoutertechni";
            this.boutonajoutertechni.Size = new System.Drawing.Size(75, 23);
            this.boutonajoutertechni.TabIndex = 2;
            this.boutonajoutertechni.Text = "Ajouter";
            this.boutonajoutertechni.UseVisualStyleBackColor = true;
            // 
            // nomtechni
            // 
            this.nomtechni.Location = new System.Drawing.Point(67, 24);
            this.nomtechni.Name = "nomtechni";
            this.nomtechni.Size = new System.Drawing.Size(100, 20);
            this.nomtechni.TabIndex = 1;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(15, 27);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(29, 13);
            this.nom.TabIndex = 0;
            this.nom.Text = "Nom";
            // 
            // lblproprietaire
            // 
            this.lblproprietaire.AutoSize = true;
            this.lblproprietaire.Location = new System.Drawing.Point(6, 79);
            this.lblproprietaire.Name = "lblproprietaire";
            this.lblproprietaire.Size = new System.Drawing.Size(102, 13);
            this.lblproprietaire.TabIndex = 16;
            this.lblproprietaire.Text = "Proprietaire materiel:";
            // 
            // comboBoxproprietaire
            // 
            this.comboBoxproprietaire.FormattingEnabled = true;
            this.comboBoxproprietaire.Items.AddRange(new object[] {
            "Locataire",
            "propriétaire"});
            this.comboBoxproprietaire.Location = new System.Drawing.Point(114, 79);
            this.comboBoxproprietaire.Name = "comboBoxproprietaire";
            this.comboBoxproprietaire.Size = new System.Drawing.Size(121, 21);
            this.comboBoxproprietaire.TabIndex = 17;
            // 
            // lblnumeromatricul
            // 
            this.lblnumeromatricul.AutoSize = true;
            this.lblnumeromatricul.Location = new System.Drawing.Point(15, 61);
            this.lblnumeromatricul.Name = "lblnumeromatricul";
            this.lblnumeromatricul.Size = new System.Drawing.Size(55, 13);
            this.lblnumeromatricul.TabIndex = 13;
            this.lblnumeromatricul.Text = "N°matricul";
            // 
            // textBoxnumeromatricul
            // 
            this.textBoxnumeromatricul.Location = new System.Drawing.Point(86, 58);
            this.textBoxnumeromatricul.Name = "textBoxnumeromatricul";
            this.textBoxnumeromatricul.Size = new System.Drawing.Size(100, 20);
            this.textBoxnumeromatricul.TabIndex = 14;
            // 
            // lblmatriculeutisateur
            // 
            this.lblmatriculeutisateur.AutoSize = true;
            this.lblmatriculeutisateur.Location = new System.Drawing.Point(15, 65);
            this.lblmatriculeutisateur.Name = "lblmatriculeutisateur";
            this.lblmatriculeutisateur.Size = new System.Drawing.Size(61, 13);
            this.lblmatriculeutisateur.TabIndex = 14;
            this.lblmatriculeutisateur.Text = "N°matricule";
            // 
            // textBoxnumeroutilisateur
            // 
            this.textBoxnumeroutilisateur.Location = new System.Drawing.Point(82, 65);
            this.textBoxnumeroutilisateur.Name = "textBoxnumeroutilisateur";
            this.textBoxnumeroutilisateur.Size = new System.Drawing.Size(100, 20);
            this.textBoxnumeroutilisateur.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.ongletutilisateur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ongletutilisateur.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbDeclaration.ResumeLayout(false);
            this.gbDeclaration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabIncidentsutili)).EndInit();
            this.onglettechnicien.ResumeLayout(false);
            this.gbGestion.ResumeLayout(false);
            this.gbGestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabincidentech)).EndInit();
            this.ongletresponsable.ResumeLayout(false);
            this.groupeboxutilisateur.ResumeLayout(false);
            this.groupeboxutilisateur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabincidentrespo)).EndInit();
            this.ajoutehni.ResumeLayout(false);
            this.ajoutehni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ongletutilisateur;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage onglettechnicien;
        private System.Windows.Forms.TabPage ongletresponsable;
        private System.Windows.Forms.GroupBox gbDeclaration;
        private System.Windows.Forms.DataGridView tabIncidentsutili;
        private System.Windows.Forms.DataGridViewTextBoxColumn numIncident;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matériel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gravité;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut;
        private System.Windows.Forms.ComboBox cbMateriel;
        private System.Windows.Forms.Label lblMateriel;
        private System.Windows.Forms.ComboBox cbGravite;
        private System.Windows.Forms.Label lblGravite;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtNomIncident;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.GroupBox gbGestion;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnenregincident;
        private System.Windows.Forms.ListBox listemateriel;
        private System.Windows.Forms.Button btnenregmateriel;
        private System.Windows.Forms.TextBox tbxmateriel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrendreEnCharge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tabincidentech;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox ajoutehni;
        private System.Windows.Forms.ListBox listetechnicien;
        private System.Windows.Forms.Button btnsupptechni;
        private System.Windows.Forms.Button boutonajoutertechni;
        private System.Windows.Forms.TextBox nomtechni;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.DataGridView tabincidentrespo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox datembauche;
        private System.Windows.Forms.TextBox roletechni;
        private System.Windows.Forms.Label lqbel;
        private System.Windows.Forms.GroupBox groupeboxutilisateur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox roleutilisateur;
        private System.Windows.Forms.ListBox listeutilisateur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nomutilisateur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button boutonmodifierutilisa;
        private System.Windows.Forms.Button boutonmodifiertechni;
        private System.Windows.Forms.Label lblproprietaire;
        private System.Windows.Forms.ComboBox comboBoxproprietaire;
        private System.Windows.Forms.TextBox textBoxnumeromatricul;
        private System.Windows.Forms.Label lblnumeromatricul;
        private System.Windows.Forms.TextBox textBoxnumeroutilisateur;
        private System.Windows.Forms.Label lblmatriculeutisateur;
    }
}

