using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Reflection;
using System.Diagnostics;
using System.Collections;
using Microsoft.BizTalk.Message.Interop;
using Microsoft.BizTalk.Component.Interop;
using Microsoft.BizTalk.Messaging;
using Microsoft.BizTalk.Streaming;

namespace Archive_pipelinecomponent
{
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [ComponentCategory(CategoryTypes.CATID_Decoder)]
    [ComponentCategory(CategoryTypes.CATID_Any)]
    [System.Runtime.InteropServices.Guid("c79c9723-7836-4f73-ace8-41acadc8f1a2")]

    
    public partial class ArchiveComponent : IBaseComponent, IComponentUI, IComponent, IPersistPropertyBag
    {
        private bool _Enabled;

        public bool Enabled
        {
            get
            {
                return _Enabled;
            }
            set
            {
                _Enabled = value;
            }
        }

        private string _FileMask;

        public string FileMask
        {
            get
            {
                return _FileMask;
            }
            set
            {
                _FileMask = value;
            }
        }

        private string _FileName;

        public string FileName
        {
            get
            {
                return _FileName;
            }
            set
            {
                _FileName = value;
            }
        }

        private string _FilePath;

        public string FilePath
        {
            get
            {
                return _FilePath;
            }
            set
            {
                _FilePath = value;
            }
        }

        private bool _Overwrite;

        public bool Overwrite
        {
            get
            {
                return _Overwrite;
            }
            set
            {
                _Overwrite = value;
            }
        }

        #region IBaseComponent members
        /// <summary>
        /// Name of the component
        /// </summary>        
        public string Name
        {
            get
            {
                return "Archive-Component";
            }
        }

        /// <summary>
        /// Version of the component
        /// </summary>        
        public string Version
        {
            get
            {
                return "1.0.0";
            }
        }

        /// <summary>
        /// Description of the component
        /// </summary>        
        public string Description
        {
            get
            {
                return "Archives source and dest messages";
            }
        }
        #endregion

        #region IPersistPropertyBag members
        /// <summary>
        /// Gets class ID of component for usage from unmanaged code.
        /// </summary>
        /// <param name="classid">
        /// Class ID of the component
        /// </param>
        public void GetClassID(out System.Guid classid)
        {
            classid = new System.Guid("740facec-2bc3-4002-ade6-69ae223ca604");
        }

        /// <summary>
        /// not implemented
        /// </summary>
        public void InitNew()
        {
        }

        /// <summary>
        /// Loads configuration properties for the component
        /// </summary>
        /// <param name="pb">Configuration property bag</param>
        /// <param name="errlog">Error status</param>
        public virtual void Load(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, int errlog)
        {
            object val = null;
            val = this.ReadPropertyBag(pb, "FilePath");
            if ((val != null))
            {
                this._FilePath = ((string)(val));
            }
            val = this.ReadPropertyBag(pb, "Enabled");
            if ((val != null))
            {
                this._Enabled = ((bool)(val));
            }
            val = this.ReadPropertyBag(pb, "FileMask");
            if ((val != null))
            {
                this._FileMask = ((string)(val));
            }
            val = this.ReadPropertyBag(pb, "FileName");
            if ((val != null))
            {
                this._FileName = ((string)(val));
            }
            val = this.ReadPropertyBag(pb, "Overwrite");
            if ((val != null))
            {
                this._Overwrite = ((bool)(val));
            }
        }

        /// <summary>
        /// Saves the current component configuration into the property bag
        /// </summary>
        /// <param name="pb">Configuration property bag</param>
        /// <param name="fClearDirty">not used</param>
        /// <param name="fSaveAllProperties">not used</param>
        public virtual void Save(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, bool fClearDirty, bool fSaveAllProperties)
        {
            this.WritePropertyBag(pb, "FilePath", this.FilePath);
            this.WritePropertyBag(pb, "Enabled", this.Enabled);
            this.WritePropertyBag(pb, "FileMask", this.FileMask);
            this.WritePropertyBag(pb, "FileName", this.FileName);
            this.WritePropertyBag(pb, "Overwrite", this.Overwrite);
        }

        #region utility functionality
        /// <summary>
        /// Reads property value from property bag
        /// </summary>
        /// <param name="pb">Property bag</param>
        /// <param name="propName">Name of property</param>
        /// <returns>Value of the property</returns>
        private object ReadPropertyBag(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, string propName)
        {
            object val = null;
            try
            {
                pb.Read(propName, out val, 0);
            }
            catch (System.ArgumentException)
            {
                return val;
            }
            catch (System.Exception e)
            {
                throw new System.ApplicationException(e.Message);
            }
            return val;
        }

        /// <summary>
        /// Writes property values into a property bag.
        /// </summary>
        /// <param name="pb">Property bag.</param>
        /// <param name="propName">Name of property.</param>
        /// <param name="val">Value of property.</param>
        private void WritePropertyBag(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, string propName, object val)
        {
            try
            {
                pb.Write(propName, ref val);
            }
            catch (System.Exception e)
            {
                throw new System.ApplicationException(e.Message);
            }
        }
        #endregion
        #endregion

        #region IComponentUI members
        /// <summary>
        /// Component icon to use in BizTalk Editor
        /// </summary>        
        public IntPtr Icon
        {
            get { return System.IntPtr.Zero; }
        }

        /// <summary>
        /// The Validate method is called by the BizTalk Editor during the build 
        /// of a BizTalk project.
        /// </summary>
        /// <param name="obj">An Object containing the configuration properties.</param>
        /// <returns>The IEnumerator enables the caller to enumerate through a collection of strings containing error messages. These error messages appear as compiler error messages. To report successful property validation, the method should return an empty enumerator.</returns>
        public System.Collections.IEnumerator Validate(object obj)
        {
            // example implementation:
            // ArrayList errorList = new ArrayList();
            // errorList.Add("This is a compiler error");
            // return errorList.GetEnumerator();
            return null;
        }
        #endregion

        #region IComponent members
        /// <summary>
        /// Implements IComponent.Execute method.
        /// </summary>
        /// <param name="pc">Pipeline context</param>
        /// <param name="inmsg">Input message</param>
        /// <returns>Original input message</returns>
        /// <remarks>
        /// IComponent.Execute method is used to initiate
        /// the processing of the message in this pipeline component.
        /// </remarks>
        public Microsoft.BizTalk.Message.Interop.IBaseMessage Execute(Microsoft.BizTalk.Component.Interop.IPipelineContext pc, Microsoft.BizTalk.Message.Interop.IBaseMessage inmsg)
        {
            Stream originalStrm = null;
            FileStream fileArchive = null;
            BinaryWriter binWriter = null;
            IBaseMessagePart bodyPart = null;
            const int bufferSize = 1024;

            try
            {
                if (Enabled)
                {
                    //IBaseMessagePart bodyPart = inmsg.BodyPart;
                    bodyPart = inmsg.BodyPart;

                    if (bodyPart != null)
                    {
                        string FullPath = "";
                        //string TransportType = "";

                        FullPath = MakeFullPath(FilePath, FileName);

                        //TransportType = inmsg.Context.Read("OutboundTransportType", "http://schemas.microsoft.com/BizTalk/2003/system-properties") as string;

                        //if (TransportType == null)
                        //{
                        //    TransportType = inmsg.Context.Read("InboundTransportType", "http://schemas.microsoft.com/BizTalk/2003/system-properties") as string;
                        //}

                        //FullPath = ProcessDateTimeMacros(FullPath, inmsg);
                        //FullPath = ProcessMessageMacros(FullPath, inmsg);
                        //FullPath = ProcessSystemPropertiesMacros(FullPath, TransportType, inmsg);

                        //switch (TransportType)
                        //{
                        //    case "FILE":
                        //        FullPath = ProcessFilePropertiesMacros(FullPath, inmsg);
                        //        break;

                        //    case "FTP":
                        //        FullPath = ProcessFTPPropertiesMacros(FullPath, inmsg);
                        //        break;
                        //}

                        if (!Directory.Exists(Path.GetDirectoryName(FullPath)))
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(FullPath));
                        }

                        if (!Overwrite)
                        {
                            if (File.Exists(FullPath + FileMask))
                            {
                                FullPath = FullPath + inmsg.MessageID.ToString();
                            }
                        }

                        FullPath = FullPath + FileMask;

                        originalStrm = bodyPart.GetOriginalDataStream();

                        if (!originalStrm.CanSeek)
                        {
                            ReadOnlySeekableStream seekableStream = new ReadOnlySeekableStream(originalStrm);
                            inmsg.BodyPart.Data = seekableStream;
                            originalStrm = inmsg.BodyPart.Data;
                        }

                        pc.ResourceTracker.AddResource(originalStrm);

                        fileArchive = new FileStream(FullPath, FileMode.Create, FileAccess.Write);
                        binWriter = new BinaryWriter(fileArchive);
                        byte[] buffer = new byte[bufferSize];
                        int sizeRead = 0;

                        while ((sizeRead = originalStrm.Read(buffer, 0, bufferSize)) != 0)
                        {
                            binWriter.Write(buffer, 0, sizeRead);
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry(ex.Source, ex.Message + "\n" + ex.StackTrace, EventLogEntryType.Warning);
            }

            finally
            {
                if (binWriter != null)
                {
                    binWriter.Flush();
                    binWriter.Close();
                }

                if (originalStrm != null)
                {
                    originalStrm.Seek(0, SeekOrigin.Begin);
                }
            }
            return inmsg;
        }
        #endregion

        #region Archive Code

        private string MakeFullPath(string FilePath, string FileName)
        {
            try
            {
                string FullPath = "";
                string Divider = "";

                if (FilePath.Substring(FilePath.Length - 1) != "\\")
                {
                    Divider = "\\";
                }

                FullPath = FilePath + Divider + FileName;

                return FullPath;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string ProcessDateTimeMacros(string Target, Microsoft.BizTalk.Message.Interop.IBaseMessage Message)
        {
            try
            {
                string UpdatedTarget = "";
                string Time = "";

                UpdatedTarget = Target.Replace("%Date%", DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString());
                UpdatedTarget = UpdatedTarget.Replace("%Day%", DateTime.Now.Day.ToString());
                UpdatedTarget = UpdatedTarget.Replace("%Month%", DateTime.Now.Month.ToString());

                Time = DateTime.Now.TimeOfDay.ToString().Replace(":", ".");

                UpdatedTarget = UpdatedTarget.Replace("%Time%", Time);
                UpdatedTarget = UpdatedTarget.Replace("%Year%", DateTime.Now.Year.ToString());

                return UpdatedTarget;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string ProcessFilePropertiesMacros(string Target, Microsoft.BizTalk.Message.Interop.IBaseMessage Message)
        {
            try
            {
                string UpdatedTarget = "";
                string ReceivedFileName = "";
                string FileName = "";
                string FileExtension = "";

                ReceivedFileName = Message.Context.Read("ReceivedFileName", "http://schemas.microsoft.com/BizTalk/2003/file-properties") as string;

                int Index = 0;
                int Index2 = 0;
                int FileNameLength = 0;

                Index = ReceivedFileName.LastIndexOf(".");
                Index2 = ReceivedFileName.LastIndexOf("\\") + 1;
                FileNameLength = Index - Index2;

                FileName = ReceivedFileName.Substring(Index2, FileNameLength);
                FileExtension = ReceivedFileName.Substring(Index);

                UpdatedTarget = Target.Replace("%FileReceivedFileName%", FileName);
                UpdatedTarget = UpdatedTarget.Replace("%FileReceivedFileExtension%", FileExtension);

                return UpdatedTarget;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string ProcessFTPPropertiesMacros(string Target, Microsoft.BizTalk.Message.Interop.IBaseMessage Message)
        {
            try
            {
                string UpdatedTarget = "";
                string ReceivedFileName = "";
                string FileName = "";
                string FileExtension = "";

                ReceivedFileName = Message.Context.Read("ReceivedFileName", "http://schemas.microsoft.com/BizTalk/2003/ftp-properties") as string;

                int Index = 0;
                //int Index2 = 0;
                int FileNameLength = 0;

                Index = ReceivedFileName.LastIndexOf(".");
                FileExtension = ReceivedFileName.Substring(Index);

                FileNameLength = ReceivedFileName.Length - FileExtension.Length;
                FileName = ReceivedFileName.Substring(0, FileNameLength);

                UpdatedTarget = Target.Replace("%FTPReceivedFileName%", FileName);
                UpdatedTarget = UpdatedTarget.Replace("%FTPReceivedFileExtension%", FileExtension);

                return UpdatedTarget;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string ProcessMessageMacros(string Target, Microsoft.BizTalk.Message.Interop.IBaseMessage Message)
        {
            try
            {
                string UpdatedTarget = "";

                UpdatedTarget = Target.Replace("%BodyPartName%", Message.BodyPartName.ToString());
                UpdatedTarget = UpdatedTarget.Replace("%MessageID%", Message.MessageID.ToString());
                UpdatedTarget = UpdatedTarget.Replace("%PartCount%", Message.PartCount.ToString());

                return UpdatedTarget;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string ProcessSystemPropertiesMacros(string Target, string TransportType, Microsoft.BizTalk.Message.Interop.IBaseMessage Message)
        {
            try
            {
                string UpdatedTarget = "";
                string Variable = "";

                UpdatedTarget = Target.Replace("%TransportType%", TransportType);

                Variable = Message.Context.Read("InterchangeID", "http://schemas.microsoft.com/BizTalk/2003/system-properties") as string;
                UpdatedTarget = UpdatedTarget.Replace("%InterchangeID%", Variable);

                Variable = Message.Context.Read("InterchangeSequenceNumber", "http://schemas.microsoft.com/BizTalk/2003/system-properties") as string;
                UpdatedTarget = UpdatedTarget.Replace("%InterchangeSequenceNumber%", Variable);

                Variable = Message.Context.Read("ReceivePortName", "http://schemas.microsoft.com/BizTalk/2003/system-properties") as string;
                UpdatedTarget = UpdatedTarget.Replace("%ReceivePortName%", Variable);

                return UpdatedTarget;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
