namespace Schemas_Project {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Schemas_Project.Customer", typeof(global::Schemas_Project.Customer))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Schemas_Project.Canonical_Schema", typeof(global::Schemas_Project.Canonical_Schema))]
    public sealed class Customer_to_canonical : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://Schemas_Project.Customer"" xmlns:ns0=""http://Schemas_Project.Canonical_Schema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Customer"" />
  </xsl:template>
  <xsl:template match=""/s0:Customer"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;1234&quot;)"" />
    <ns0:Canonical>
      <Name>
        <xsl:value-of select=""Name/text()"" />
      </Name>
      <Id>
        <xsl:value-of select=""$var:v1"" />
      </Id>
      <City>
        <xsl:value-of select=""City/text()"" />
      </City>
      <Address>
        <xsl:value-of select=""Address/text()"" />
      </Address>
    </ns0:Canonical>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Schemas_Project.Customer";
        
        private const global::Schemas_Project.Customer _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Schemas_Project.Canonical_Schema";
        
        private const global::Schemas_Project.Canonical_Schema _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Schemas_Project.Customer";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Schemas_Project.Canonical_Schema";
                return _TrgSchemas;
            }
        }
    }
}
