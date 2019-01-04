namespace Schemas_Project {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Schemas_Project.Canonical_Schema", typeof(global::Schemas_Project.Canonical_Schema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Schemas_Project.Procedure_dbo+InsertintoCustomers", typeof(global::Schemas_Project.Procedure_dbo.InsertintoCustomers))]
    public sealed class Canonical_To_SQLDB : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" xmlns:ns3=""http://schemas.datacontract.org/2004/07/System.Data"" xmlns:s0=""http://Schemas_Project.Canonical_Schema"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Canonical"" />
  </xsl:template>
  <xsl:template match=""/s0:Canonical"">
    <ns0:InsertintoCustomers>
      <ns0:Name>
        <xsl:value-of select=""Name/text()"" />
      </ns0:Name>
      <ns0:Id>
        <xsl:value-of select=""Id/text()"" />
      </ns0:Id>
      <ns0:City>
        <xsl:value-of select=""City/text()"" />
      </ns0:City>
      <ns0:Address>
        <xsl:value-of select=""Address/text()"" />
      </ns0:Address>
    </ns0:InsertintoCustomers>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Schemas_Project.Canonical_Schema";
        
        private const global::Schemas_Project.Canonical_Schema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Schemas_Project.Procedure_dbo+InsertintoCustomers";
        
        private const global::Schemas_Project.Procedure_dbo.InsertintoCustomers _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Schemas_Project.Canonical_Schema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Schemas_Project.Procedure_dbo+InsertintoCustomers";
                return _TrgSchemas;
            }
        }
    }
}
