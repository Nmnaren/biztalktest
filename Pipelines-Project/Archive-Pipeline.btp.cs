namespace Pipelines_Project
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class Archive_Pipeline : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s>        <Component>          <Name>Archive_pipelinecomponent.ArchiveComponent,Archive-pipelinecomp"+
"onent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b0d80af1b9136be1</Name>          <ComponentN"+
"ame>Archive-Component</ComponentName>          <Description>Archives source and dest messages</Descr"+
"iption>          <Version>1.0.0</Version>          <Properties>            <Property Name=\"FilePath\""+
" />            <Property Name=\"Enabled\">              <Value xsi:type=\"xsd:boolean\">true</Value>    "+
"        </Property>            <Property Name=\"FileMask\" />            <Property Name=\"FileName\" /> "+
"           <Property Name=\"Overwrite\">              <Value xsi:type=\"xsd:boolean\">false</Value>     "+
"       </Property>          </Properties>          <CachedDisplayName>Archive-Component</CachedDispl"+
"ayName>          <CachedIsManaged>true</CachedIsManaged>        </Component>      </Components>    <"+
"/Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" minOccurs"+
"=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" />      <"+
"Components>        <Component>          <Name>Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizT"+
"alk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>   "+
"       <ComponentName>XML disassembler</ComponentName>          <Description>Streaming XML disassemb"+
"ler</Description>          <Version>1.0</Version>          <Properties>            <Property Name=\"E"+
"nvelopeSpecNames\">              <Value xsi:type=\"xsd:string\" />            </Property>            <P"+
"roperty Name=\"EnvelopeSpecTargetNamespaces\">              <Value xsi:type=\"xsd:string\" />           "+
" </Property>            <Property Name=\"DocumentSpecNames\">              <Value xsi:type=\"xsd:string"+
"\" />            </Property>            <Property Name=\"DocumentSpecTargetNamespaces\">              <"+
"Value xsi:type=\"xsd:string\" />            </Property>            <Property Name=\"AllowUnrecognizedMe"+
"ssage\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>            <"+
"Property Name=\"ValidateDocument\">              <Value xsi:type=\"xsd:boolean\">false</Value>          "+
"  </Property>            <Property Name=\"RecoverableInterchangeProcessing\">              <Value xsi:"+
"type=\"xsd:boolean\">false</Value>            </Property>            <Property Name=\"HiddenProperties\""+
">              <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTargetNamespace"+
"s</Value>            </Property>          </Properties>          <CachedDisplayName>XML disassembler"+
"</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>        </Component>      </Com"+
"ponents>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name=\"Validate\""+
" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536-83fa-4a5040674ad6\" />    "+
"  <Components />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"4\" Name=\"R"+
"esolveParty\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410e-4cce-4536-83fa-4a504067"+
"4ad6\" />      <Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "44957ce5-9208-42e1-bd55-1908a3cf2b7b";
        
        public Archive_Pipeline()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4103-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Archive_pipelinecomponent.ArchiveComponent,Archive-pipelinecomponent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b0d80af1b9136be1");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"FilePath\" />   "+
" <Property Name=\"Enabled\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Proper"+
"ty Name=\"FileMask\" />    <Property Name=\"FileName\" />    <Property Name=\"Overwrite\">      <Value xsi"+
":type=\"xsd:boolean\">false</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
            stage = this.AddStage(new System.Guid("9d0e4105-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.firstRecognized);
            IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp1 is IPersistPropertyBag)
            {
                string comp1XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"EnvelopeSpecNam"+
"es\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"EnvelopeSpecTargetNamesp"+
"aces\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecNames\">   "+
"   <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecTargetNamespaces\"> "+
"     <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"AllowUnrecognizedMessage\">   "+
"   <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"ValidateDocument\"> "+
"     <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"RecoverableInterc"+
"hangeProcessing\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name="+
"\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTarge"+
"tNamespaces</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp1XmlProperties);;
                ((IPersistPropertyBag)(comp1)).Load(pb, 0);
            }
            this.AddComponent(stage, comp1);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
