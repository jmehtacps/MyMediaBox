namespace MyMediaBox.Models
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRoot("AllProjects")]
    public partial class AllProjects
    {

        private AllProjectsProj[] projField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Proj")]
        public AllProjectsProj[] Proj
        {
            get
            {
                return this.projField;
            }
            set
            {
                this.projField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AllProjectsProj
    {

        private ushort projectIDField;

        private string projectNumberField;

        private AllProjectsProjSub[] allSubmissionsField;

        /// <remarks/>
        public ushort ProjectID
        {
            get
            {
                return this.projectIDField;
            }
            set
            {
                this.projectIDField = value;
            }
        }

        /// <remarks/>
        public string ProjectNumber
        {
            get
            {
                return this.projectNumberField;
            }
            set
            {
                this.projectNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Sub", IsNullable = false)]
        public AllProjectsProjSub[] AllSubmissions
        {
            get
            {
                return this.allSubmissionsField;
            }
            set
            {
                this.allSubmissionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AllProjectsProjSub
    {

        private byte submissionIDField;

        private string submissionNumberField;

        private string typeField;

        /// <remarks/>
        public byte SubmissionID
        {
            get
            {
                return this.submissionIDField;
            }
            set
            {
                this.submissionIDField = value;
            }
        }

        /// <remarks/>
        public string SubmissionNumber
        {
            get
            {
                return this.submissionNumberField;
            }
            set
            {
                this.submissionNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }


}