// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CodexDataFullNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CodexDataFullNotify.proto</summary>
  public static partial class CodexDataFullNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for CodexDataFullNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CodexDataFullNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlDb2RleERhdGFGdWxsTm90aWZ5LnByb3RvGhNDb2RleFR5cGVEYXRhLnBy",
            "b3RvIpQBChNDb2RleERhdGFGdWxsTm90aWZ5EhsKE1VuazI3MDBfQlBLT0xI",
            "T09HRk8YBCABKA0SGwoTVW5rMjcwMF9ERkpKSEZISElIRhgCIAMoDRIbChNV",
            "bmsyNzAwX0hKRE5CQlBNT0FQGAMgASgNEiYKDnR5cGVfZGF0YV9saXN0GAYg",
            "AygLMg4uQ29kZXhUeXBlRGF0YUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0",
            "d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.CodexTypeDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CodexDataFullNotify), global::Weedwacker.Shared.Network.Proto.CodexDataFullNotify.Parser, new[]{ "Unk2700BPKOLHOOGFO", "Unk2700DFJJHFHHIHF", "Unk2700HJDNBBPMOAP", "TypeDataList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4205
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class CodexDataFullNotify : pb::IMessage<CodexDataFullNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CodexDataFullNotify> _parser = new pb::MessageParser<CodexDataFullNotify>(() => new CodexDataFullNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CodexDataFullNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CodexDataFullNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CodexDataFullNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CodexDataFullNotify(CodexDataFullNotify other) : this() {
      unk2700BPKOLHOOGFO_ = other.unk2700BPKOLHOOGFO_;
      unk2700DFJJHFHHIHF_ = other.unk2700DFJJHFHHIHF_.Clone();
      unk2700HJDNBBPMOAP_ = other.unk2700HJDNBBPMOAP_;
      typeDataList_ = other.typeDataList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CodexDataFullNotify Clone() {
      return new CodexDataFullNotify(this);
    }

    /// <summary>Field number for the "Unk2700_BPKOLHOOGFO" field.</summary>
    public const int Unk2700BPKOLHOOGFOFieldNumber = 4;
    private uint unk2700BPKOLHOOGFO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700BPKOLHOOGFO {
      get { return unk2700BPKOLHOOGFO_; }
      set {
        unk2700BPKOLHOOGFO_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_DFJJHFHHIHF" field.</summary>
    public const int Unk2700DFJJHFHHIHFFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_unk2700DFJJHFHHIHF_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> unk2700DFJJHFHHIHF_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk2700DFJJHFHHIHF {
      get { return unk2700DFJJHFHHIHF_; }
    }

    /// <summary>Field number for the "Unk2700_HJDNBBPMOAP" field.</summary>
    public const int Unk2700HJDNBBPMOAPFieldNumber = 3;
    private uint unk2700HJDNBBPMOAP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700HJDNBBPMOAP {
      get { return unk2700HJDNBBPMOAP_; }
      set {
        unk2700HJDNBBPMOAP_ = value;
      }
    }

    /// <summary>Field number for the "type_data_list" field.</summary>
    public const int TypeDataListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.CodexTypeData> _repeated_typeDataList_codec
        = pb::FieldCodec.ForMessage(50, global::Weedwacker.Shared.Network.Proto.CodexTypeData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CodexTypeData> typeDataList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CodexTypeData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CodexTypeData> TypeDataList {
      get { return typeDataList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CodexDataFullNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CodexDataFullNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2700BPKOLHOOGFO != other.Unk2700BPKOLHOOGFO) return false;
      if(!unk2700DFJJHFHHIHF_.Equals(other.unk2700DFJJHFHHIHF_)) return false;
      if (Unk2700HJDNBBPMOAP != other.Unk2700HJDNBBPMOAP) return false;
      if(!typeDataList_.Equals(other.typeDataList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2700BPKOLHOOGFO != 0) hash ^= Unk2700BPKOLHOOGFO.GetHashCode();
      hash ^= unk2700DFJJHFHHIHF_.GetHashCode();
      if (Unk2700HJDNBBPMOAP != 0) hash ^= Unk2700HJDNBBPMOAP.GetHashCode();
      hash ^= typeDataList_.GetHashCode();
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
      unk2700DFJJHFHHIHF_.WriteTo(output, _repeated_unk2700DFJJHFHHIHF_codec);
      if (Unk2700HJDNBBPMOAP != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk2700HJDNBBPMOAP);
      }
      if (Unk2700BPKOLHOOGFO != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk2700BPKOLHOOGFO);
      }
      typeDataList_.WriteTo(output, _repeated_typeDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unk2700DFJJHFHHIHF_.WriteTo(ref output, _repeated_unk2700DFJJHFHHIHF_codec);
      if (Unk2700HJDNBBPMOAP != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk2700HJDNBBPMOAP);
      }
      if (Unk2700BPKOLHOOGFO != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk2700BPKOLHOOGFO);
      }
      typeDataList_.WriteTo(ref output, _repeated_typeDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Unk2700BPKOLHOOGFO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700BPKOLHOOGFO);
      }
      size += unk2700DFJJHFHHIHF_.CalculateSize(_repeated_unk2700DFJJHFHHIHF_codec);
      if (Unk2700HJDNBBPMOAP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700HJDNBBPMOAP);
      }
      size += typeDataList_.CalculateSize(_repeated_typeDataList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CodexDataFullNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk2700BPKOLHOOGFO != 0) {
        Unk2700BPKOLHOOGFO = other.Unk2700BPKOLHOOGFO;
      }
      unk2700DFJJHFHHIHF_.Add(other.unk2700DFJJHFHHIHF_);
      if (other.Unk2700HJDNBBPMOAP != 0) {
        Unk2700HJDNBBPMOAP = other.Unk2700HJDNBBPMOAP;
      }
      typeDataList_.Add(other.typeDataList_);
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
            unk2700DFJJHFHHIHF_.AddEntriesFrom(input, _repeated_unk2700DFJJHFHHIHF_codec);
            break;
          }
          case 24: {
            Unk2700HJDNBBPMOAP = input.ReadUInt32();
            break;
          }
          case 32: {
            Unk2700BPKOLHOOGFO = input.ReadUInt32();
            break;
          }
          case 50: {
            typeDataList_.AddEntriesFrom(input, _repeated_typeDataList_codec);
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
            unk2700DFJJHFHHIHF_.AddEntriesFrom(ref input, _repeated_unk2700DFJJHFHHIHF_codec);
            break;
          }
          case 24: {
            Unk2700HJDNBBPMOAP = input.ReadUInt32();
            break;
          }
          case 32: {
            Unk2700BPKOLHOOGFO = input.ReadUInt32();
            break;
          }
          case 50: {
            typeDataList_.AddEntriesFrom(ref input, _repeated_typeDataList_codec);
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