// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_IBEKDNOGMLA.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_IBEKDNOGMLA.proto</summary>
  public static partial class Unk2700IBEKDNOGMLAReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_IBEKDNOGMLA.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700IBEKDNOGMLAReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0lCRUtETk9HTUxBLnByb3RvGhlVbmsyNzAwX0lOTU5IS09Q",
            "Q0ZCLnByb3RvIoEBChNVbmsyNzAwX0lCRUtETk9HTUxBEjEKE1VuazI3MDBf",
            "Sk9OT01GRU5ERlAYBSABKAsyFC5VbmsyNzAwX0lOTU5IS09QQ0ZCEhsKE1Vu",
            "azI3MDBfTUpMSEVGSUdJS0QYAiADKA0SGgoSZXhpdF9wb2ludF9pZF9saXN0",
            "GA0gAygNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2700INMNHKOPCFBReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_IBEKDNOGMLA), global::Weedwacker.Shared.Network.Proto.Unk2700_IBEKDNOGMLA.Parser, new[]{ "Unk2700JONOMFENDFP", "Unk2700MJLHEFIGIKD", "ExitPointIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk2700_IBEKDNOGMLA : pb::IMessage<Unk2700_IBEKDNOGMLA>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_IBEKDNOGMLA> _parser = new pb::MessageParser<Unk2700_IBEKDNOGMLA>(() => new Unk2700_IBEKDNOGMLA());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_IBEKDNOGMLA> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700IBEKDNOGMLAReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_IBEKDNOGMLA() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_IBEKDNOGMLA(Unk2700_IBEKDNOGMLA other) : this() {
      unk2700JONOMFENDFP_ = other.unk2700JONOMFENDFP_ != null ? other.unk2700JONOMFENDFP_.Clone() : null;
      unk2700MJLHEFIGIKD_ = other.unk2700MJLHEFIGIKD_.Clone();
      exitPointIdList_ = other.exitPointIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_IBEKDNOGMLA Clone() {
      return new Unk2700_IBEKDNOGMLA(this);
    }

    /// <summary>Field number for the "Unk2700_JONOMFENDFP" field.</summary>
    public const int Unk2700JONOMFENDFPFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.Unk2700_INMNHKOPCFB unk2700JONOMFENDFP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Unk2700_INMNHKOPCFB Unk2700JONOMFENDFP {
      get { return unk2700JONOMFENDFP_; }
      set {
        unk2700JONOMFENDFP_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_MJLHEFIGIKD" field.</summary>
    public const int Unk2700MJLHEFIGIKDFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_unk2700MJLHEFIGIKD_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> unk2700MJLHEFIGIKD_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk2700MJLHEFIGIKD {
      get { return unk2700MJLHEFIGIKD_; }
    }

    /// <summary>Field number for the "exit_point_id_list" field.</summary>
    public const int ExitPointIdListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_exitPointIdList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> exitPointIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ExitPointIdList {
      get { return exitPointIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_IBEKDNOGMLA);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_IBEKDNOGMLA other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Unk2700JONOMFENDFP, other.Unk2700JONOMFENDFP)) return false;
      if(!unk2700MJLHEFIGIKD_.Equals(other.unk2700MJLHEFIGIKD_)) return false;
      if(!exitPointIdList_.Equals(other.exitPointIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (unk2700JONOMFENDFP_ != null) hash ^= Unk2700JONOMFENDFP.GetHashCode();
      hash ^= unk2700MJLHEFIGIKD_.GetHashCode();
      hash ^= exitPointIdList_.GetHashCode();
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
      unk2700MJLHEFIGIKD_.WriteTo(output, _repeated_unk2700MJLHEFIGIKD_codec);
      if (unk2700JONOMFENDFP_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Unk2700JONOMFENDFP);
      }
      exitPointIdList_.WriteTo(output, _repeated_exitPointIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unk2700MJLHEFIGIKD_.WriteTo(ref output, _repeated_unk2700MJLHEFIGIKD_codec);
      if (unk2700JONOMFENDFP_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Unk2700JONOMFENDFP);
      }
      exitPointIdList_.WriteTo(ref output, _repeated_exitPointIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (unk2700JONOMFENDFP_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk2700JONOMFENDFP);
      }
      size += unk2700MJLHEFIGIKD_.CalculateSize(_repeated_unk2700MJLHEFIGIKD_codec);
      size += exitPointIdList_.CalculateSize(_repeated_exitPointIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_IBEKDNOGMLA other) {
      if (other == null) {
        return;
      }
      if (other.unk2700JONOMFENDFP_ != null) {
        if (unk2700JONOMFENDFP_ == null) {
          Unk2700JONOMFENDFP = new global::Weedwacker.Shared.Network.Proto.Unk2700_INMNHKOPCFB();
        }
        Unk2700JONOMFENDFP.MergeFrom(other.Unk2700JONOMFENDFP);
      }
      unk2700MJLHEFIGIKD_.Add(other.unk2700MJLHEFIGIKD_);
      exitPointIdList_.Add(other.exitPointIdList_);
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
          case 18:
          case 16: {
            unk2700MJLHEFIGIKD_.AddEntriesFrom(input, _repeated_unk2700MJLHEFIGIKD_codec);
            break;
          }
          case 42: {
            if (unk2700JONOMFENDFP_ == null) {
              Unk2700JONOMFENDFP = new global::Weedwacker.Shared.Network.Proto.Unk2700_INMNHKOPCFB();
            }
            input.ReadMessage(Unk2700JONOMFENDFP);
            break;
          }
          case 106:
          case 104: {
            exitPointIdList_.AddEntriesFrom(input, _repeated_exitPointIdList_codec);
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
          case 18:
          case 16: {
            unk2700MJLHEFIGIKD_.AddEntriesFrom(ref input, _repeated_unk2700MJLHEFIGIKD_codec);
            break;
          }
          case 42: {
            if (unk2700JONOMFENDFP_ == null) {
              Unk2700JONOMFENDFP = new global::Weedwacker.Shared.Network.Proto.Unk2700_INMNHKOPCFB();
            }
            input.ReadMessage(Unk2700JONOMFENDFP);
            break;
          }
          case 106:
          case 104: {
            exitPointIdList_.AddEntriesFrom(ref input, _repeated_exitPointIdList_codec);
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
