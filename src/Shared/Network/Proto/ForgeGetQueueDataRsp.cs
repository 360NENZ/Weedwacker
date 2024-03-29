// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ForgeGetQueueDataRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ForgeGetQueueDataRsp.proto</summary>
  public static partial class ForgeGetQueueDataRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ForgeGetQueueDataRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ForgeGetQueueDataRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpGb3JnZUdldFF1ZXVlRGF0YVJzcC5wcm90bxoURm9yZ2VRdWV1ZURhdGEu",
            "cHJvdG8iyAEKFEZvcmdlR2V0UXVldWVEYXRhUnNwEkEKD2ZvcmdlX3F1ZXVl",
            "X21hcBgCIAMoCzIoLkZvcmdlR2V0UXVldWVEYXRhUnNwLkZvcmdlUXVldWVN",
            "YXBFbnRyeRIPCgdyZXRjb2RlGA8gASgFEhUKDW1heF9xdWV1ZV9udW0YBiAB",
            "KA0aRQoSRm9yZ2VRdWV1ZU1hcEVudHJ5EgsKA2tleRgBIAEoDRIeCgV2YWx1",
            "ZRgCIAEoCzIPLkZvcmdlUXVldWVEYXRhOgI4AUIiqgIfV2VlZHdhY2tlci5T",
            "aGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ForgeQueueDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ForgeGetQueueDataRsp), global::Weedwacker.Shared.Network.Proto.ForgeGetQueueDataRsp.Parser, new[]{ "ForgeQueueMap", "Retcode", "MaxQueueNum" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 641
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class ForgeGetQueueDataRsp : pb::IMessage<ForgeGetQueueDataRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ForgeGetQueueDataRsp> _parser = new pb::MessageParser<ForgeGetQueueDataRsp>(() => new ForgeGetQueueDataRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ForgeGetQueueDataRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ForgeGetQueueDataRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForgeGetQueueDataRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForgeGetQueueDataRsp(ForgeGetQueueDataRsp other) : this() {
      forgeQueueMap_ = other.forgeQueueMap_.Clone();
      retcode_ = other.retcode_;
      maxQueueNum_ = other.maxQueueNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForgeGetQueueDataRsp Clone() {
      return new ForgeGetQueueDataRsp(this);
    }

    /// <summary>Field number for the "forge_queue_map" field.</summary>
    public const int ForgeQueueMapFieldNumber = 2;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.ForgeQueueData>.Codec _map_forgeQueueMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.ForgeQueueData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.ForgeQueueData.Parser), 18);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.ForgeQueueData> forgeQueueMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.ForgeQueueData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.ForgeQueueData> ForgeQueueMap {
      get { return forgeQueueMap_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 15;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "max_queue_num" field.</summary>
    public const int MaxQueueNumFieldNumber = 6;
    private uint maxQueueNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxQueueNum {
      get { return maxQueueNum_; }
      set {
        maxQueueNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ForgeGetQueueDataRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ForgeGetQueueDataRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!ForgeQueueMap.Equals(other.ForgeQueueMap)) return false;
      if (Retcode != other.Retcode) return false;
      if (MaxQueueNum != other.MaxQueueNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= ForgeQueueMap.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (MaxQueueNum != 0) hash ^= MaxQueueNum.GetHashCode();
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
      forgeQueueMap_.WriteTo(output, _map_forgeQueueMap_codec);
      if (MaxQueueNum != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MaxQueueNum);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(Retcode);
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
      forgeQueueMap_.WriteTo(ref output, _map_forgeQueueMap_codec);
      if (MaxQueueNum != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MaxQueueNum);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(Retcode);
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
      size += forgeQueueMap_.CalculateSize(_map_forgeQueueMap_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (MaxQueueNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxQueueNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ForgeGetQueueDataRsp other) {
      if (other == null) {
        return;
      }
      forgeQueueMap_.Add(other.forgeQueueMap_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.MaxQueueNum != 0) {
        MaxQueueNum = other.MaxQueueNum;
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
          case 18: {
            forgeQueueMap_.AddEntriesFrom(input, _map_forgeQueueMap_codec);
            break;
          }
          case 48: {
            MaxQueueNum = input.ReadUInt32();
            break;
          }
          case 120: {
            Retcode = input.ReadInt32();
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
          case 18: {
            forgeQueueMap_.AddEntriesFrom(ref input, _map_forgeQueueMap_codec);
            break;
          }
          case 48: {
            MaxQueueNum = input.ReadUInt32();
            break;
          }
          case 120: {
            Retcode = input.ReadInt32();
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
