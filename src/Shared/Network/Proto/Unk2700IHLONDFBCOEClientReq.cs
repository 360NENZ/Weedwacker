// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_IHLONDFBCOE_ClientReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_IHLONDFBCOE_ClientReq.proto</summary>
  public static partial class Unk2700IHLONDFBCOEClientReqReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_IHLONDFBCOE_ClientReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700IHLONDFBCOEClientReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNVbmsyNzAwX0lITE9OREZCQ09FX0NsaWVudFJlcS5wcm90bxoZVW5rMjcw",
            "MF9PUEVCTUpQT09CTC5wcm90byJSCh1VbmsyNzAwX0lITE9OREZCQ09FX0Ns",
            "aWVudFJlcRIxChNVbmsyNzAwX0tIQkRBUEdET0pBGA0gASgOMhQuVW5rMjcw",
            "MF9PUEVCTUpQT09CTEIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2700OPEBMJPOOBLReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_IHLONDFBCOE_ClientReq), global::Weedwacker.Shared.Network.Proto.Unk2700_IHLONDFBCOE_ClientReq.Parser, new[]{ "Unk2700KHBDAPGDOJA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 6320
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class Unk2700_IHLONDFBCOE_ClientReq : pb::IMessage<Unk2700_IHLONDFBCOE_ClientReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_IHLONDFBCOE_ClientReq> _parser = new pb::MessageParser<Unk2700_IHLONDFBCOE_ClientReq>(() => new Unk2700_IHLONDFBCOE_ClientReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_IHLONDFBCOE_ClientReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700IHLONDFBCOEClientReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_IHLONDFBCOE_ClientReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_IHLONDFBCOE_ClientReq(Unk2700_IHLONDFBCOE_ClientReq other) : this() {
      unk2700KHBDAPGDOJA_ = other.unk2700KHBDAPGDOJA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_IHLONDFBCOE_ClientReq Clone() {
      return new Unk2700_IHLONDFBCOE_ClientReq(this);
    }

    /// <summary>Field number for the "Unk2700_KHBDAPGDOJA" field.</summary>
    public const int Unk2700KHBDAPGDOJAFieldNumber = 13;
    private global::Weedwacker.Shared.Network.Proto.Unk2700_OPEBMJPOOBL unk2700KHBDAPGDOJA_ = global::Weedwacker.Shared.Network.Proto.Unk2700_OPEBMJPOOBL.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Unk2700_OPEBMJPOOBL Unk2700KHBDAPGDOJA {
      get { return unk2700KHBDAPGDOJA_; }
      set {
        unk2700KHBDAPGDOJA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_IHLONDFBCOE_ClientReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_IHLONDFBCOE_ClientReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2700KHBDAPGDOJA != other.Unk2700KHBDAPGDOJA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2700KHBDAPGDOJA != global::Weedwacker.Shared.Network.Proto.Unk2700_OPEBMJPOOBL.None) hash ^= Unk2700KHBDAPGDOJA.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Unk2700KHBDAPGDOJA != global::Weedwacker.Shared.Network.Proto.Unk2700_OPEBMJPOOBL.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Unk2700KHBDAPGDOJA);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Unk2700KHBDAPGDOJA != global::Weedwacker.Shared.Network.Proto.Unk2700_OPEBMJPOOBL.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Unk2700KHBDAPGDOJA);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Unk2700KHBDAPGDOJA != global::Weedwacker.Shared.Network.Proto.Unk2700_OPEBMJPOOBL.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Unk2700KHBDAPGDOJA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_IHLONDFBCOE_ClientReq other) {
      if (other == null) {
        return;
      }
      if (other.Unk2700KHBDAPGDOJA != global::Weedwacker.Shared.Network.Proto.Unk2700_OPEBMJPOOBL.None) {
        Unk2700KHBDAPGDOJA = other.Unk2700KHBDAPGDOJA;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 104: {
            Unk2700KHBDAPGDOJA = (global::Weedwacker.Shared.Network.Proto.Unk2700_OPEBMJPOOBL) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 104: {
            Unk2700KHBDAPGDOJA = (global::Weedwacker.Shared.Network.Proto.Unk2700_OPEBMJPOOBL) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
