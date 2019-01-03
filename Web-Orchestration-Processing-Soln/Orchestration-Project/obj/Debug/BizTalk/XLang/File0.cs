
#pragma warning disable 162

namespace Orchestration_Project
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Orchestration_Project.__messagetype_Schemas_Project_Customer), 
            typeof(Orchestration_Project.__messagetype_Schemas_Project_Canonical_Schema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Customer_PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Customer_PortType_1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Customer_PortType_1(Customer_PortType_1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Customer_PortType_1 p = new Customer_PortType_1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(Customer_PortType_1),
            typeof(__messagetype_Schemas_Project_Customer),
            typeof(__messagetype_Schemas_Project_Canonical_Schema),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Orchestration_Project.__messagetype_Schemas_Project_Procedure_dbo_InsertintoCustomers)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class DB_PortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public DB_PortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public DB_PortType(DB_PortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            DB_PortType p = new DB_PortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(DB_PortType),
            typeof(__messagetype_Schemas_Project_Procedure_dbo_InsertintoCustomers),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Orchestration_Project.__messagetype_ART_BizTalk_CanonicalSchemas_Canonical_Fault)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_1(PortType_1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_1 p = new PortType_1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_1),
            typeof(__messagetype_ART_BizTalk_CanonicalSchemas_Canonical_Fault),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 360 "D:\Akmal\BizTalk\Rest\Web-Orchestration-Processing-Soln\Orchestration-Project\Process-customer.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Customer_Port", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Orchestration_Project.Customer_PortType_1),
            typeof(Orchestration_Project.DB_PortType),
            typeof(Orchestration_Project.PortType_1)
        },
        new System.String[] {
            "Customer_Port",
            "Port_DB",
            "Send_fault"
        },
        new System.Type[] {
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eLongRunning
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class Process_customer : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Process_customer));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static Process_customer()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 2, 3),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment4), 1, 2, 4),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment5), 1, 2, 5)
            };

            _Locks = 0;
            _rootContext = new __Process_customer_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Process_customer(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Process_customer", tracker)
        {
            ConstructorHelper();
        }

        public Process_customer(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Process_customer")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>f665c7c1-4315-4067-921d-4ea0dcee5b9e</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>06710e2f-6e3a-4e99-ab31-a1dbccf81828</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>f774a254-5927-416e-ae34-4c7239a8bb99</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>LongRunningTransactionShape</shapeType>      <ShapeID>a817bbb9-2ba0-4928-8743-b6ab897b4dc7</ShapeID>      <ParentLink>Scope_Transaction</ParentLink>                <shapeText>Transaction_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>17645652-e0d3-4e41-8764-2b08046b949c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>3bbf8e08-ea70-428d-ab52-de70cf71c3cf</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>ef8be349-7242-4315-8693-24fe3738c9e9</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>5a830e3d-dd28-4f44-92d3-bbe8e3de8cc8</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>ef6a6b47-1121-443c-851e-c014bf828e94</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelShape</shapeType>      <ShapeID>ec6e244d-ca50-483c-adf3-b54535844058</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ParallelActions_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>1b595f41-7f2e-4dab-9249-2afa26f5d4f4</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>4abd5be8-1b43-41bc-8701-33b6330a5cb7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f75e1523-e4cc-438f-aa3f-dd2a680e10c1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>449d9e49-6615-402e-9c08-5341acb22c5c</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>e6ebe4d9-6933-40a5-97a3-89c4dd5c2e7f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>a2f40115-ed60-49b0-a8b1-5f775a04bde3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>dc5eedab-0627-4947-8aa3-86dd3b380567</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>36923882-164a-44a3-867f-a732b9c17f4a</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>95df12ee-ca42-4de6-ba1a-60d349342b25</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>9e95c866-1f6c-4211-91c7-1d057f752631</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>e4618118-f6b2-4306-a642-922a6bb27220</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_1</shapeText>                      <ExceptionType>System.Net.Mail.SmtpFailedRecipientException</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>98961c6b-9241-4675-a78f-ebdeeb7aa076</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>ConstructMessage_3</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>3dad7b2c-dfd7-4716-a4cb-335ee16f77b0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>fbbf8dea-d74f-4bb8-962b-ffdbaca8286e</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>faddb429-3090-49ee-82a8-79fb59bdaeb0</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Send_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Process_customer'</ActionName><IsAtomic>0</IsAtomic><Line>360</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>377</Line><Position>22</Position><ShapeID>'06710e2f-6e3a-4e99-ab31-a1dbccf81828'</ShapeID>
<Messages>
	<MsgInfo><name>msgCustomer</name><part>part</part><schema>Schemas_Project.Customer</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'Transaction_2'</ActionName><IsAtomic>0</IsAtomic><Line>380</Line><Position>13</Position><ShapeID>'f774a254-5927-416e-ae34-4c7239a8bb99'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>385</Line><Position>21</Position><ShapeID>'17645652-e0d3-4e41-8764-2b08046b949c'</ShapeID>
<Messages>
	<MsgInfo><name>msgCanonical</name><part>part</part><schema>Schemas_Project.Canonical_Schema</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgCustomer</name><part>part</part><schema>Schemas_Project.Customer</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>391</Line><Position>21</Position><ShapeID>'ec6e244d-ca50-483c-adf3-b54535844058'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>396</Line><Position>29</Position><ShapeID>'4abd5be8-1b43-41bc-8701-33b6330a5cb7'</ShapeID>
<Messages>
	<MsgInfo><name>msgCanonical</name><part>part</part><schema>Schemas_Project.Canonical_Schema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>398</Line><Position>29</Position><ShapeID>'f75e1523-e4cc-438f-aa3f-dd2a680e10c1'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>403</Line><Position>29</Position><ShapeID>'e6ebe4d9-6933-40a5-97a3-89c4dd5c2e7f'</ShapeID>
<Messages>
	<MsgInfo><name>msgInsertIntoDB</name><part>part</part><schema>Schemas_Project.Procedure_dbo+InsertintoCustomers</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgCanonical</name><part>part</part><schema>Schemas_Project.Canonical_Schema</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>409</Line><Position>29</Position><ShapeID>'9e95c866-1f6c-4211-91c7-1d057f752631'</ShapeID>
<Messages>
	<MsgInfo><name>msgInsertIntoDB</name><part>part</part><schema>Schemas_Project.Procedure_dbo+InsertintoCustomers</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>416</Line><Position>21</Position><ShapeID>'e4618118-f6b2-4306-a642-922a6bb27220'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>419</Line><Position>25</Position><ShapeID>'98961c6b-9241-4675-a78f-ebdeeb7aa076'</ShapeID>
<Messages>
	<MsgInfo><name>msgCanonicalExcp</name><part>part</part><schema>ART.BizTalk.CanonicalSchemas.Canonical_Fault</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>432</Line><Position>25</Position><ShapeID>'faddb429-3090-49ee-82a8-79fb59bdaeb0'</ShapeID>
<Messages>
	<MsgInfo><name>msgCanonicalExcp</name><part>part</part><schema>ART.BizTalk.CanonicalSchemas.Canonical_Fault</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='dbf164c1-2feb-44f9-b138-bbdd149172b7' LowerBound='1.1' HigherBound='105.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Orchestration_Project' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='5bbbe791-77c3-4f28-a811-af8c4465e69b' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Customer_PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='03ac1cc5-ae7a-436f-8c9e-dcfacc715555' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='624d82bb-9b1e-4b59-aa81-93df7bfaba52' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.37'>
                    <om:Property Name='Ref' Value='Schemas_Project.Customer' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='0a8a9666-6914-41d2-9d2f-36cdb4a742e6' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.39' HigherBound='8.71'>
                    <om:Property Name='Ref' Value='Schemas_Project.Canonical_Schema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='1e013747-b6fb-4aab-bcc4-0840e02d2e0f' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DB_PortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='81c41995-e18c-4b46-8824-220b19c240a7' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='98801deb-68c8-4f44-a9e7-8678f9484eb4' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.62'>
                    <om:Property Name='Ref' Value='Schemas_Project.Procedure_dbo.InsertintoCustomers' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='c7e0a789-ff15-46e4-829f-e01fbf18b390' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='a1a501b8-8902-4b72-abae-df5fa3f08d3c' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='eb5b7b6b-4185-4033-9a75-921fdf89b335' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.57'>
                    <om:Property Name='Ref' Value='ART.BizTalk.CanonicalSchemas.Canonical_Fault' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='1b5cec41-ae44-40ee-83ba-1d68d81eeebf' ParentLink='Module_ServiceDeclaration' LowerBound='25.1' HigherBound='104.1'>
            <om:Property Name='InitializedTransactionType' Value='True' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Process_customer' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='f8ae377f-f7c0-4aef-940d-580f39255c97' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='39.1' HigherBound='40.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='varXml' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='LongRunningTransaction' OID='e6cf2d7b-4a60-4080-b071-6aa541589feb' ParentLink='ServiceDeclaration_Transaction' LowerBound='26.21' HigherBound='26.62'>
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Transaction_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='31309838-7548-46be-bd01-40d711a8810a' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='Type' Value='Schemas_Project.Customer' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgCustomer' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='222e8fec-76d6-4d2e-9cdb-37e1290d130e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='Type' Value='Schemas_Project.Canonical_Schema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgCanonical' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='7ed907ef-2581-4b25-8ef8-ed2e2d49a29e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='Type' Value='Schemas_Project.Procedure_dbo.InsertintoCustomers' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgInsertIntoDB' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='3fe4a1df-0422-46d7-943c-7798a2497cd9' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='37.1' HigherBound='38.1'>
                <om:Property Name='Type' Value='ART.BizTalk.CanonicalSchemas.Canonical_Fault' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgCanonicalExcp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='fde29dc8-e32e-4bb2-b162-f10437a09e5d' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='38.1' HigherBound='39.1'>
                <om:Property Name='Type' Value='ART.BizTalk.CanonicalSchemas.Canonical_Fault' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgFinalCanonicalExcep' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='f665c7c1-4315-4067-921d-4ea0dcee5b9e' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='06710e2f-6e3a-4e99-ab31-a1dbccf81828' ParentLink='ServiceBody_Statement' LowerBound='42.1' HigherBound='45.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Customer_Port' />
                    <om:Property Name='MessageName' Value='msgCustomer' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='f774a254-5927-416e-ae34-4c7239a8bb99' ParentLink='ServiceBody_Statement' LowerBound='45.1' HigherBound='102.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='LongRunningTransaction' OID='a817bbb9-2ba0-4928-8743-b6ab897b4dc7' ParentLink='Scope_Transaction' LowerBound='46.18' HigherBound='46.56'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transaction_2' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Construct' OID='17645652-e0d3-4e41-8764-2b08046b949c' ParentLink='ComplexStatement_Statement' LowerBound='50.1' HigherBound='56.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Transform' OID='3bbf8e08-ea70-428d-ab52-de70cf71c3cf' ParentLink='ComplexStatement_Statement' LowerBound='53.1' HigherBound='55.1'>
                            <om:Property Name='ClassName' Value='Schemas_Project.Customer_to_canonical' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Transform_1' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessagePartRef' OID='ef8be349-7242-4315-8693-24fe3738c9e9' ParentLink='Transform_InputMessagePartRef' LowerBound='54.91' HigherBound='54.102'>
                                <om:Property Name='MessageRef' Value='msgCustomer' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='5a830e3d-dd28-4f44-92d3-bbe8e3de8cc8' ParentLink='Transform_OutputMessagePartRef' LowerBound='54.36' HigherBound='54.48'>
                                <om:Property Name='MessageRef' Value='msgCanonical' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageRef' OID='ef6a6b47-1121-443c-851e-c014bf828e94' ParentLink='Construct_MessageRef' LowerBound='51.31' HigherBound='51.43'>
                            <om:Property Name='Ref' Value='msgCanonical' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Parallel' OID='ec6e244d-ca50-483c-adf3-b54535844058' ParentLink='ComplexStatement_Statement' LowerBound='56.1' HigherBound='78.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelActions_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='ParallelBranch' OID='1b595f41-7f2e-4dab-9249-2afa26f5d4f4' ParentLink='ReallyComplexStatement_Branch' LowerBound='61.1' HigherBound='65.1'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ParallelBranch_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Send' OID='4abd5be8-1b43-41bc-8701-33b6330a5cb7' ParentLink='ComplexStatement_Statement' LowerBound='61.1' HigherBound='63.1'>
                                <om:Property Name='PortName' Value='Customer_Port' />
                                <om:Property Name='MessageName' Value='msgCanonical' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Response' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='f75e1523-e4cc-438f-aa3f-dd2a680e10c1' ParentLink='ComplexStatement_Statement' LowerBound='63.1' HigherBound='65.1'>
                                <om:Property Name='Expression' Value='throw new System.Exception(&quot;This is an exception&quot;);' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Expression_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='ParallelBranch' OID='449d9e49-6615-402e-9c08-5341acb22c5c' ParentLink='ReallyComplexStatement_Branch' LowerBound='68.1' HigherBound='76.1'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ParallelBranch_2' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Construct' OID='e6ebe4d9-6933-40a5-97a3-89c4dd5c2e7f' ParentLink='ComplexStatement_Statement' LowerBound='68.1' HigherBound='74.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_2' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Transform' OID='a2f40115-ed60-49b0-a8b1-5f775a04bde3' ParentLink='ComplexStatement_Statement' LowerBound='71.1' HigherBound='73.1'>
                                    <om:Property Name='ClassName' Value='Schemas_Project.Canonical_To_SQLDB' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_2' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessagePartRef' OID='dc5eedab-0627-4947-8aa3-86dd3b380567' ParentLink='Transform_InputMessagePartRef' LowerBound='72.99' HigherBound='72.111'>
                                        <om:Property Name='MessageRef' Value='msgCanonical' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_3' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='36923882-164a-44a3-867f-a732b9c17f4a' ParentLink='Transform_OutputMessagePartRef' LowerBound='72.44' HigherBound='72.59'>
                                        <om:Property Name='MessageRef' Value='msgInsertIntoDB' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_4' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageRef' OID='95df12ee-ca42-4de6-ba1a-60d349342b25' ParentLink='Construct_MessageRef' LowerBound='69.39' HigherBound='69.54'>
                                    <om:Property Name='Ref' Value='msgInsertIntoDB' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='9e95c866-1f6c-4211-91c7-1d057f752631' ParentLink='ComplexStatement_Statement' LowerBound='74.1' HigherBound='76.1'>
                                <om:Property Name='PortName' Value='Port_DB' />
                                <om:Property Name='MessageName' Value='msgInsertIntoDB' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_2' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='e4618118-f6b2-4306-a642-922a6bb27220' ParentLink='Scope_Catch' LowerBound='81.1' HigherBound='100.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Net.Mail.SmtpFailedRecipientException' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='98961c6b-9241-4675-a78f-ebdeeb7aa076' ParentLink='Catch_Statement' LowerBound='84.1' HigherBound='97.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_3' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='3dad7b2c-dfd7-4716-a4cb-335ee16f77b0' ParentLink='ComplexStatement_Statement' LowerBound='87.1' HigherBound='96.1'>
                                <om:Property Name='Expression' Value='varXml.LoadXml(@&quot;&lt;ns0:Canonical_Fault xmlns:ns0=&quot;&quot;http://ART.BizTalk.CanonicalSchemas.Canonical_Fault&quot;&quot;&gt; &lt;ErrorCode&gt;1234&lt;/ErrorCode&gt; &lt;ErrorType&gt;Failed Message&lt;/ErrorType&gt; &lt;ErrorDescription&gt;Error description&lt;/ErrorDescription&gt; &lt;/ns0:Canonical_Fault&gt;&quot;);&#xD;&#xA;msgCanonicalExcp = varXml;&#xD;&#xA;&#xD;&#xA;//msgCanonicalExcp.ErrorCode = &quot;123&quot;;&#xD;&#xA;//msgCanonicalExcp.ErrorType = &quot;Failure&quot;;&#xD;&#xA;//msgCanonicalExcp.ErrorDescription = &quot; Failed message&quot;;&#xD;&#xA;&#xD;&#xA;//msgFinalCanonicalExcep(*) = msgCanonicalExcp(*);' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='fbbf8dea-d74f-4bb8-962b-ffdbaca8286e' ParentLink='Construct_MessageRef' LowerBound='85.35' HigherBound='85.51'>
                                <om:Property Name='Ref' Value='msgCanonicalExcp' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='faddb429-3090-49ee-82a8-79fb59bdaeb0' ParentLink='Catch_Statement' LowerBound='97.1' HigherBound='99.1'>
                            <om:Property Name='PortName' Value='Send_fault' />
                            <om:Property Name='MessageName' Value='msgCanonicalExcp' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_3' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='7a61138f-3957-4568-b270-b3ffaf720edf' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='28.1' HigherBound='30.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Orchestration_Project.Customer_PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Customer_Port' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='137c79f6-0b55-4afc-961b-26d7f50542c0' ParentLink='PortDeclaration_CLRAttribute' LowerBound='28.1' HigherBound='29.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='ade3c552-6fc1-4559-80f6-53d6213ef7c4' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='30.1' HigherBound='32.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Orchestration_Project.DB_PortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_DB' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='8eab2363-f7f7-4efb-bfaf-95bde79932de' ParentLink='PortDeclaration_CLRAttribute' LowerBound='30.1' HigherBound='31.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='55cdf011-d1bb-479b-b671-68a80a76d9ca' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='32.1' HigherBound='34.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Orchestration_Project.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Send_fault' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='811d2fe0-a260-431f-bfb6-da8485d4f3d5' ParentLink='PortDeclaration_CLRAttribute' LowerBound='32.1' HigherBound='33.1'>
                    <om:Property Name='DirectBindingType' Value='MessageBox' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Process_customer_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Process_customer_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Process_customer")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                Process_customer __svc__ = (Process_customer)_service;
                __Process_customer_root_0 __ctx0__ = (__Process_customer_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Port_DB != null)
                {
                    __svc__.Port_DB.Close(this, null);
                    __svc__.Port_DB = null;
                }
                if (__svc__.Customer_Port != null)
                {
                    __svc__.Customer_Port.Close(this, null);
                    __svc__.Customer_Port = null;
                }
                if (__svc__.Send_fault != null)
                {
                    __svc__.Send_fault.Close(this, null);
                    __svc__.Send_fault = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __Process_customer_1 : Microsoft.XLANGs.Core.LongRunningTransaction
        {
            public __Process_customer_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Process_customer")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                Process_customer __svc__ = (Process_customer)_service;
                __Transaction_2_2 __ctx2__ = (__Transaction_2_2)(__svc__._stateMgrs[2]);
                __Process_customer_1 __ctx1__ = (__Process_customer_1)(__svc__._stateMgrs[1]);

                if (__ctx2__ != null && __ctx2__.__msgCanonicalExcp != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgCanonicalExcp);
                    __ctx2__.__msgCanonicalExcp = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgCanonical != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCanonical);
                    __ctx1__.__msgCanonical = null;
                }
                if (__ctx2__ != null && __ctx2__.__msgCanonical != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgCanonical);
                    __ctx2__.__msgCanonical = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__varXml = null;
                if (__ctx2__ != null && __ctx2__.__msgInsertIntoDB != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgInsertIntoDB);
                    __ctx2__.__msgInsertIntoDB = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgCanonicalExcp != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCanonicalExcp);
                    __ctx1__.__msgCanonicalExcp = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgCustomer != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomer);
                    __ctx1__.__msgCustomer = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgInsertIntoDB != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgInsertIntoDB);
                    __ctx1__.__msgInsertIntoDB = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCustomer")]
            public __messagetype_Schemas_Project_Customer __msgCustomer;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCanonical")]
            public __messagetype_Schemas_Project_Canonical_Schema __msgCanonical;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgInsertIntoDB")]
            public __messagetype_Schemas_Project_Procedure_dbo_InsertintoCustomers __msgInsertIntoDB;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCanonicalExcp")]
            public __messagetype_ART_BizTalk_CanonicalSchemas_Canonical_Fault __msgCanonicalExcp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("varXml")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __varXml;
        }


        [System.SerializableAttribute]
        public class __Transaction_2_2 : Microsoft.XLANGs.Core.LongRunningTransaction
        {
            public __Transaction_2_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Transaction_2")
            {
            }

            public override int Index { get { return 2; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Net.Mail.SmtpFailedRecipientException))
                    {
                        __seg__ = _service._segments[5];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                Process_customer __svc__ = (Process_customer)_service;
                __Transaction_2_2 __ctx2__ = (__Transaction_2_2)(__svc__._stateMgrs[2]);
                __Process_customer_1 __ctx1__ = (__Process_customer_1)(__svc__._stateMgrs[1]);

                if (__ctx1__.__msgCanonical != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgCanonical);
                __ctx1__.__msgCanonical = __ctx2__.__msgCanonical;
                if (__ctx2__.__msgCanonical != null)
                    __ctx1__.RefMessage(__ctx1__.__msgCanonical);
                if (__ctx1__.__msgInsertIntoDB != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgInsertIntoDB);
                __ctx1__.__msgInsertIntoDB = __ctx2__.__msgInsertIntoDB;
                if (__ctx2__.__msgInsertIntoDB != null)
                    __ctx1__.RefMessage(__ctx1__.__msgInsertIntoDB);
                if (__ctx1__.__msgCanonicalExcp != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgCanonicalExcp);
                __ctx1__.__msgCanonicalExcp = __ctx2__.__msgCanonicalExcp;
                if (__ctx2__.__msgCanonicalExcp != null)
                    __ctx1__.RefMessage(__ctx1__.__msgCanonicalExcp);
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCanonical")]
            public __messagetype_Schemas_Project_Canonical_Schema __msgCanonical;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgInsertIntoDB")]
            public __messagetype_Schemas_Project_Procedure_dbo_InsertintoCustomers __msgInsertIntoDB;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCanonicalExcp")]
            public __messagetype_ART_BizTalk_CanonicalSchemas_Canonical_Fault __msgCanonicalExcp;
            internal object __exv__;
            internal System.Net.Mail.SmtpFailedRecipientException __ex_0
            {
                get { return (System.Net.Mail.SmtpFailedRecipientException)__exv__; }
                set { __exv__ = value; }
            }
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Customer_Port")]
        internal Customer_PortType_1 Customer_Port;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_DB")]
        internal DB_PortType Port_DB;
        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Send_fault")]
        internal PortType_1 Send_fault;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Customer_PortType_1.Operation_1},
                                               typeof(Process_customer).GetField("Customer_Port", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Process_customer), "Customer_Port"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DB_PortType.Operation_1},
                                               typeof(Process_customer).GetField("Port_DB", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Process_customer), "Port_DB"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(Process_customer).GetField("Send_fault", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Process_customer), "Send_fault"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "06710e2f-6e3a-4e99-ab31-a1dbccf81828", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "06710e2f-6e3a-4e99-ab31-a1dbccf81828", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "f774a254-5927-416e-ae34-4c7239a8bb99", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "17645652-e0d3-4e41-8764-2b08046b949c", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "17645652-e0d3-4e41-8764-2b08046b949c", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "ec6e244d-ca50-483c-adf3-b54535844058", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "ec6e244d-ca50-483c-adf3-b54535844058", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "4abd5be8-1b43-41bc-8701-33b6330a5cb7", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "4abd5be8-1b43-41bc-8701-33b6330a5cb7", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "f75e1523-e4cc-438f-aa3f-dd2a680e10c1", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "e6ebe4d9-6933-40a5-97a3-89c4dd5c2e7f", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "e6ebe4d9-6933-40a5-97a3-89c4dd5c2e7f", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "9e95c866-1f6c-4211-91c7-1d057f752631", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "9e95c866-1f6c-4211-91c7-1d057f752631", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "e4618118-f6b2-4306-a642-922a6bb27220", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "98961c6b-9241-4675-a78f-ebdeeb7aa076", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "98961c6b-9241-4675-a78f-ebdeeb7aa076", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "faddb429-3090-49ee-82a8-79fb59bdaeb0", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "faddb429-3090-49ee-82a8-79fb59bdaeb0", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "e4618118-f6b2-4306-a642-922a6bb27220", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "f774a254-5927-416e-ae34-4c7239a8bb99", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Parallel),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Throw),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Parallel),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,4,4,4,23,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,8,9,9,9,9,9,};
        public static int[] __progressLocation3 = new int[] { 10,10,10,11,12,12,9,};
        public static int[] __progressLocation4 = new int[] { 13,13,14,15,15,15,16,9,};
        public static int[] __progressLocation5 = new int[] { 17,17,18,18,19,20,20,20,21,22,22,};

        public static int[][] __progressLocations = new int[6] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3,__progressLocation4,__progressLocation5};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __Process_customer_root_0 __ctx0__ = (__Process_customer_root_0)_stateMgrs[0];
            __Process_customer_1 __ctx1__ = (__Process_customer_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Customer_Port = new Customer_PortType_1(0, this);
                Port_DB = new DB_PortType(1, this);
                Send_fault = new PortType_1(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Customer_Port, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Process_customer_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __Process_customer_root_0 __ctx0__ = (__Process_customer_root_0)_stateMgrs[0];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];
            __Process_customer_1 __ctx1__ = (__Process_customer_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__varXml = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!Customer_Port.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgCustomer != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomer);
                __ctx1__.__msgCustomer = new __messagetype_Schemas_Project_Customer("msgCustomer", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgCustomer);
                Customer_Port.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgCustomer, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgCustomer);
                    __edata.PortName = @"Customer_Port";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__varXml.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __ctx2__ = new __Transaction_2_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__varXml = null;
                if (__ctx1__ != null && __ctx1__.__msgCustomer != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomer);
                    __ctx1__.__msgCustomer = null;
                }
                if (Send_fault != null)
                {
                    Send_fault.Close(__ctx1__, __seg__);
                    Send_fault = null;
                }
                if (Port_DB != null)
                {
                    Port_DB.Close(__ctx1__, __seg__);
                    Port_DB = null;
                }
                if (Customer_Port != null)
                {
                    Customer_Port.Close(__ctx1__, __seg__);
                    Customer_Port = null;
                }
                Tracker.FireEvent(__eventLocations[23],__eventData[10],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (__ctx2__ != null && __ctx2__.__msgCanonicalExcp != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgCanonicalExcp);
                    __ctx2__.__msgCanonicalExcp = null;
                }
                if (__ctx2__ != null && __ctx2__.__msgInsertIntoDB != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgInsertIntoDB);
                    __ctx2__.__msgInsertIntoDB = null;
                }
                if (__ctx2__ != null && __ctx2__.__msgCanonical != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgCanonical);
                    __ctx2__.__msgCanonical = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgCanonicalExcp != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCanonicalExcp);
                    __ctx1__.__msgCanonicalExcp = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgInsertIntoDB != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgInsertIntoDB);
                    __ctx1__.__msgInsertIntoDB = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgCanonical != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCanonical);
                    __ctx1__.__msgCanonical = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[11],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 13;
            case 13:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];
            __Process_customer_1 __ctx1__ = (__Process_customer_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx2__.__msgCanonical = __ctx1__.__msgCanonical;
                if (__ctx2__.__msgCanonical != null)
                    __ctx2__.RefMessage(__ctx2__.__msgCanonical);
                __ctx2__.__msgInsertIntoDB = __ctx1__.__msgInsertIntoDB;
                if (__ctx2__.__msgInsertIntoDB != null)
                    __ctx2__.RefMessage(__ctx2__.__msgInsertIntoDB);
                __ctx2__.__msgCanonicalExcp = __ctx1__.__msgCanonicalExcp;
                if (__ctx2__.__msgCanonicalExcp != null)
                    __ctx2__.RefMessage(__ctx2__.__msgCanonicalExcp);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                {
                    __messagetype_Schemas_Project_Canonical_Schema __msgCanonical = new __messagetype_Schemas_Project_Canonical_Schema("msgCanonical", __ctx2__);

                    ApplyTransform(typeof(Schemas_Project.Customer_to_canonical), new object[] {__msgCanonical.part}, new object[] {__ctx1__.__msgCustomer.part});

                    if (__ctx2__.__msgCanonical != null)
                        __ctx2__.UnrefMessage(__ctx2__.__msgCanonical);
                    __ctx2__.__msgCanonical = __msgCanonical;
                    __ctx2__.RefMessage(__ctx2__.__msgCanonical);
                }
                __ctx2__.__msgCanonical.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__msgCanonical);
                    __edata.Messages.Add(__ctx1__.__msgCustomer);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __seg__.RunSegments(new Microsoft.XLANGs.Core.Segment[] {_segments[3], _segments[4]}, this);
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 9;
            case 9:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __Process_customer_root_0 __ctx0__ = (__Process_customer_root_0)_stateMgrs[0];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Customer_Port.SendMessage(0, __ctx2__.__msgCanonical, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx2__.__msgCanonical);
                    __edata.PortName = @"Customer_Port";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                throw new System.Exception("This is an exception");
            case 6:
                __seg__.SegmentDone();
                _segments[2].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment4(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[4];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __Process_customer_root_0 __ctx0__ = (__Process_customer_root_0)_stateMgrs[0];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                {
                    __messagetype_Schemas_Project_Procedure_dbo_InsertintoCustomers __msgInsertIntoDB = new __messagetype_Schemas_Project_Procedure_dbo_InsertintoCustomers("msgInsertIntoDB", __ctx2__);

                    ApplyTransform(typeof(Schemas_Project.Canonical_To_SQLDB), new object[] {__msgInsertIntoDB.part}, new object[] {__ctx2__.__msgCanonical.part});

                    if (__ctx2__.__msgInsertIntoDB != null)
                        __ctx2__.UnrefMessage(__ctx2__.__msgInsertIntoDB);
                    __ctx2__.__msgInsertIntoDB = __msgInsertIntoDB;
                    __ctx2__.RefMessage(__ctx2__.__msgInsertIntoDB);
                }
                __ctx2__.__msgInsertIntoDB.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__msgInsertIntoDB);
                    __edata.Messages.Add(__ctx2__.__msgCanonical);
                    Tracker.FireEvent(__eventLocations[14],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_DB.SendMessage(0, __ctx2__.__msgInsertIntoDB, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx2__.__msgInsertIntoDB);
                    __edata.PortName = @"Port_DB";
                    Tracker.FireEvent(__eventLocations[16],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __seg__.SegmentDone();
                _segments[2].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment5(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[5];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __Process_customer_root_0 __ctx0__ = (__Process_customer_root_0)_stateMgrs[0];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];
            __Process_customer_1 __ctx1__ = (__Process_customer_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                {
                    __messagetype_ART_BizTalk_CanonicalSchemas_Canonical_Fault __msgCanonicalExcp = new __messagetype_ART_BizTalk_CanonicalSchemas_Canonical_Fault("msgCanonicalExcp", __ctx2__);

                    __ctx1__.__varXml.UnderlyingXmlDocument.LoadXml(@"<ns0:Canonical_Fault xmlns:ns0=""http://ART.BizTalk.CanonicalSchemas.Canonical_Fault""> <ErrorCode>1234</ErrorCode> <ErrorType>Failed Message</ErrorType> <ErrorDescription>Error description</ErrorDescription> </ns0:Canonical_Fault>");
                    __msgCanonicalExcp.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__varXml.UnderlyingXmlDocument);

                    if (__ctx2__.__msgCanonicalExcp != null)
                        __ctx2__.UnrefMessage(__ctx2__.__msgCanonicalExcp);
                    __ctx2__.__msgCanonicalExcp = __msgCanonicalExcp;
                    __ctx2__.RefMessage(__ctx2__.__msgCanonicalExcp);
                }
                __ctx2__.__msgCanonicalExcp.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__msgCanonicalExcp);
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Send_fault.SendMessage(0, __ctx2__.__msgCanonicalExcp, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx2__.__msgCanonicalExcp);
                    __edata.PortName = @"Send_fault";
                    Tracker.FireEvent(__eventLocations[21],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Schemas_Project_Customer__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Schemas_Project.Customer _schema = new Schemas_Project.Customer();

        public __Schemas_Project_Customer__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Schemas_Project.Customer",
        new System.Type[]{
            typeof(Schemas_Project.Customer)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Schemas_Project_Customer__)
        },
        0,
        @"http://Schemas_Project.Customer#Customer"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Schemas_Project_Customer : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Schemas_Project_Customer__ part;

        private void __CreatePartWrappers()
        {
            part = new __Schemas_Project_Customer__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Schemas_Project_Customer(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Schemas_Project_Canonical_Schema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Schemas_Project.Canonical_Schema _schema = new Schemas_Project.Canonical_Schema();

        public __Schemas_Project_Canonical_Schema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Schemas_Project.Canonical_Schema",
        new System.Type[]{
            typeof(Schemas_Project.Canonical_Schema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Schemas_Project_Canonical_Schema__)
        },
        0,
        @"http://Schemas_Project.Canonical_Schema#Canonical"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Schemas_Project_Canonical_Schema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Schemas_Project_Canonical_Schema__ part;

        private void __CreatePartWrappers()
        {
            part = new __Schemas_Project_Canonical_Schema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Schemas_Project_Canonical_Schema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Schemas_Project_Procedure_dbo_InsertintoCustomers__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Schemas_Project.Procedure_dbo.InsertintoCustomers _schema = new Schemas_Project.Procedure_dbo.InsertintoCustomers();

        public __Schemas_Project_Procedure_dbo_InsertintoCustomers__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Schemas_Project.Procedure_dbo.InsertintoCustomers",
        new System.Type[]{
            typeof(Schemas_Project.Procedure_dbo.InsertintoCustomers)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Schemas_Project_Procedure_dbo_InsertintoCustomers__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo#InsertintoCustomers"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Schemas_Project_Procedure_dbo_InsertintoCustomers : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Schemas_Project_Procedure_dbo_InsertintoCustomers__ part;

        private void __CreatePartWrappers()
        {
            part = new __Schemas_Project_Procedure_dbo_InsertintoCustomers__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Schemas_Project_Procedure_dbo_InsertintoCustomers(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __ART_BizTalk_CanonicalSchemas_Canonical_Fault__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static ART.BizTalk.CanonicalSchemas.Canonical_Fault _schema = new ART.BizTalk.CanonicalSchemas.Canonical_Fault();

        public __ART_BizTalk_CanonicalSchemas_Canonical_Fault__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "ART.BizTalk.CanonicalSchemas.Canonical_Fault",
        new System.Type[]{
            typeof(ART.BizTalk.CanonicalSchemas.Canonical_Fault)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__ART_BizTalk_CanonicalSchemas_Canonical_Fault__)
        },
        0,
        @"http://ART.BizTalk.CanonicalSchemas.Canonical_Fault#Canonical_Fault"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_ART_BizTalk_CanonicalSchemas_Canonical_Fault : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __ART_BizTalk_CanonicalSchemas_Canonical_Fault__ part;

        private void __CreatePartWrappers()
        {
            part = new __ART_BizTalk_CanonicalSchemas_Canonical_Fault__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_ART_BizTalk_CanonicalSchemas_Canonical_Fault(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
