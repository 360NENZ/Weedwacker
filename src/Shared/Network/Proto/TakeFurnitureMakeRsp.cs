// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeFurnitureMakeRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from TakeFurnitureMakeRsp.proto</summary>
  public static partial class TakeFurnitureMakeRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TakeFurnitureMakeRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TakeFurnitureMakeRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpUYWtlRnVybml0dXJlTWFrZVJzcC5wcm90bxoXRnVybml0dXJlTWFrZVNs",
            "b3QucHJvdG8aD0l0ZW1QYXJhbS5wcm90byK1AQoUVGFrZUZ1cm5pdHVyZU1h",
            "a2VSc3ASLwoTZnVybml0dXJlX21ha2Vfc2xvdBgIIAEoCzISLkZ1cm5pdHVy",
            "ZU1ha2VTbG90EiQKEHJldHVybl9pdGVtX2xpc3QYAiADKAsyCi5JdGVtUGFy",
            "YW0SDwoHbWFrZV9pZBgGIAEoDRIPCgdyZXRjb2RlGAkgASgFEiQKEG91dHB1",
            "dF9pdGVtX2xpc3QYDiADKAsyCi5JdGVtUGFyYW1CIqoCH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.FurnitureMakeSlotReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.TakeFurnitureMakeRsp), global::Weedwacker.Shared.Network.Proto.TakeFurnitureMakeRsp.Parser, new[]{ "FurnitureMakeSlot", "ReturnItemList", "MakeId", "Retcode", "OutputItemList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4769
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class TakeFurnitureMakeRsp : pb::IMessage<TakeFurnitureMakeRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TakeFurnitureMakeRsp> _parser = new pb::MessageParser<TakeFurnitureMakeRsp>(() => new TakeFurnitureMakeRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TakeFurnitureMakeRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.TakeFurnitureMakeRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeFurnitureMakeRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeFurnitureMakeRsp(TakeFurnitureMakeRsp other) : this() {
      furnitureMakeSlot_ = other.furnitureMakeSlot_ != null ? other.furnitureMakeSlot_.Clone() : null;
      returnItemList_ = other.returnItemList_.Clone();
      makeId_ = other.makeId_;
      retcode_ = other.retcode_;
      outputItemList_ = other.outputItemList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeFurnitureMakeRsp Clone() {
      return new TakeFurnitureMakeRsp(this);
    }

    /// <summary>Field number for the "furniture_make_slot" field.</summary>
    public const int FurnitureMakeSlotFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.FurnitureMakeSlot furnitureMakeSlot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.FurnitureMakeSlot FurnitureMakeSlot {
      get { return furnitureMakeSlot_; }
      set {
        furnitureMakeSlot_ = value;
      }
    }

    /// <summary>Field number for the "return_item_list" field.</summary>
    public const int ReturnItemListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_returnItemList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> returnItemList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> ReturnItemList {
      get { return returnItemList_; }
    }

    /// <summary>Field number for the "make_id" field.</summary>
    public const int MakeIdFieldNumber = 6;
    private uint makeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MakeId {
      get { return makeId_; }
      set {
        makeId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 9;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "output_item_list" field.</summary>
    public const int OutputItemListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_outputItemList_codec
        = pb::FieldCodec.ForMessage(114, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> outputItemList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> OutputItemList {
      get { return outputItemList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TakeFurnitureMakeRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TakeFurnitureMakeRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(FurnitureMakeSlot, other.FurnitureMakeSlot)) return false;
      if(!returnItemList_.Equals(other.returnItemList_)) return false;
      if (MakeId != other.MakeId) return false;
      if (Retcode != other.Retcode) return false;
      if(!outputItemList_.Equals(other.outputItemList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (furnitureMakeSlot_ != null) hash ^= FurnitureMakeSlot.GetHashCode();
      hash ^= returnItemList_.GetHashCode();
      if (MakeId != 0) hash ^= MakeId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= outputItemList_.GetHashCode();
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
      returnItemList_.WriteTo(output, _repeated_returnItemList_codec);
      if (MakeId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MakeId);
      }
      if (furnitureMakeSlot_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(FurnitureMakeSlot);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Retcode);
      }
      outputItemList_.WriteTo(output, _repeated_outputItemList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      returnItemList_.WriteTo(ref output, _repeated_returnItemList_codec);
      if (MakeId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MakeId);
      }
      if (furnitureMakeSlot_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(FurnitureMakeSlot);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Retcode);
      }
      outputItemList_.WriteTo(ref output, _repeated_outputItemList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (furnitureMakeSlot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FurnitureMakeSlot);
      }
      size += returnItemList_.CalculateSize(_repeated_returnItemList_codec);
      if (MakeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MakeId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += outputItemList_.CalculateSize(_repeated_outputItemList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TakeFurnitureMakeRsp other) {
      if (other == null) {
        return;
      }
      if (other.furnitureMakeSlot_ != null) {
        if (furnitureMakeSlot_ == null) {
          FurnitureMakeSlot = new global::Weedwacker.Shared.Network.Proto.FurnitureMakeSlot();
        }
        FurnitureMakeSlot.MergeFrom(other.FurnitureMakeSlot);
      }
      returnItemList_.Add(other.returnItemList_);
      if (other.MakeId != 0) {
        MakeId = other.MakeId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      outputItemList_.Add(other.outputItemList_);
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
            returnItemList_.AddEntriesFrom(input, _repeated_returnItemList_codec);
            break;
          }
          case 48: {
            MakeId = input.ReadUInt32();
            break;
          }
          case 66: {
            if (furnitureMakeSlot_ == null) {
              FurnitureMakeSlot = new global::Weedwacker.Shared.Network.Proto.FurnitureMakeSlot();
            }
            input.ReadMessage(FurnitureMakeSlot);
            break;
          }
          case 72: {
            Retcode = input.ReadInt32();
            break;
          }
          case 114: {
            outputItemList_.AddEntriesFrom(input, _repeated_outputItemList_codec);
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
            returnItemList_.AddEntriesFrom(ref input, _repeated_returnItemList_codec);
            break;
          }
          case 48: {
            MakeId = input.ReadUInt32();
            break;
          }
          case 66: {
            if (furnitureMakeSlot_ == null) {
              FurnitureMakeSlot = new global::Weedwacker.Shared.Network.Proto.FurnitureMakeSlot();
            }
            input.ReadMessage(FurnitureMakeSlot);
            break;
          }
          case 72: {
            Retcode = input.ReadInt32();
            break;
          }
          case 114: {
            outputItemList_.AddEntriesFrom(ref input, _repeated_outputItemList_codec);
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
