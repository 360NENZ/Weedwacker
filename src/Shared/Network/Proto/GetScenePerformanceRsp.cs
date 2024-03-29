// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetScenePerformanceRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GetScenePerformanceRsp.proto</summary>
  public static partial class GetScenePerformanceRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetScenePerformanceRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetScenePerformanceRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHZXRTY2VuZVBlcmZvcm1hbmNlUnNwLnByb3RvGgxWZWN0b3IucHJvdG8i",
            "2gEKFkdldFNjZW5lUGVyZm9ybWFuY2VSc3ASEwoLbW9uc3Rlcl9udW0YCSAB",
            "KA0SGgoSZ2F0aGVyX251bV9pbnNpZ2h0GAEgASgNEhIKCmdhZGdldF9udW0Y",
            "BiABKA0SDwoHcmV0Y29kZRgHIAEoBRIZChFkeW5hbWljX2dyb3VwX251bRgM",
            "IAEoDRIRCglncm91cF9udW0YAiABKA0SFAoDcG9zGAQgASgLMgcuVmVjdG9y",
            "EhIKCmVudGl0eV9udW0YCCABKA0SEgoKZ2F0aGVyX251bRgNIAEoDUIiqgIf",
            "V2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GetScenePerformanceRsp), global::Weedwacker.Shared.Network.Proto.GetScenePerformanceRsp.Parser, new[]{ "MonsterNum", "GatherNumInsight", "GadgetNum", "Retcode", "DynamicGroupNum", "GroupNum", "Pos", "EntityNum", "GatherNum" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 3137
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class GetScenePerformanceRsp : pb::IMessage<GetScenePerformanceRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetScenePerformanceRsp> _parser = new pb::MessageParser<GetScenePerformanceRsp>(() => new GetScenePerformanceRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetScenePerformanceRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GetScenePerformanceRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetScenePerformanceRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetScenePerformanceRsp(GetScenePerformanceRsp other) : this() {
      monsterNum_ = other.monsterNum_;
      gatherNumInsight_ = other.gatherNumInsight_;
      gadgetNum_ = other.gadgetNum_;
      retcode_ = other.retcode_;
      dynamicGroupNum_ = other.dynamicGroupNum_;
      groupNum_ = other.groupNum_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      entityNum_ = other.entityNum_;
      gatherNum_ = other.gatherNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetScenePerformanceRsp Clone() {
      return new GetScenePerformanceRsp(this);
    }

    /// <summary>Field number for the "monster_num" field.</summary>
    public const int MonsterNumFieldNumber = 9;
    private uint monsterNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MonsterNum {
      get { return monsterNum_; }
      set {
        monsterNum_ = value;
      }
    }

    /// <summary>Field number for the "gather_num_insight" field.</summary>
    public const int GatherNumInsightFieldNumber = 1;
    private uint gatherNumInsight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GatherNumInsight {
      get { return gatherNumInsight_; }
      set {
        gatherNumInsight_ = value;
      }
    }

    /// <summary>Field number for the "gadget_num" field.</summary>
    public const int GadgetNumFieldNumber = 6;
    private uint gadgetNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetNum {
      get { return gadgetNum_; }
      set {
        gadgetNum_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "dynamic_group_num" field.</summary>
    public const int DynamicGroupNumFieldNumber = 12;
    private uint dynamicGroupNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DynamicGroupNum {
      get { return dynamicGroupNum_; }
      set {
        dynamicGroupNum_ = value;
      }
    }

    /// <summary>Field number for the "group_num" field.</summary>
    public const int GroupNumFieldNumber = 2;
    private uint groupNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupNum {
      get { return groupNum_; }
      set {
        groupNum_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "entity_num" field.</summary>
    public const int EntityNumFieldNumber = 8;
    private uint entityNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityNum {
      get { return entityNum_; }
      set {
        entityNum_ = value;
      }
    }

    /// <summary>Field number for the "gather_num" field.</summary>
    public const int GatherNumFieldNumber = 13;
    private uint gatherNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GatherNum {
      get { return gatherNum_; }
      set {
        gatherNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetScenePerformanceRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetScenePerformanceRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MonsterNum != other.MonsterNum) return false;
      if (GatherNumInsight != other.GatherNumInsight) return false;
      if (GadgetNum != other.GadgetNum) return false;
      if (Retcode != other.Retcode) return false;
      if (DynamicGroupNum != other.DynamicGroupNum) return false;
      if (GroupNum != other.GroupNum) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (EntityNum != other.EntityNum) return false;
      if (GatherNum != other.GatherNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MonsterNum != 0) hash ^= MonsterNum.GetHashCode();
      if (GatherNumInsight != 0) hash ^= GatherNumInsight.GetHashCode();
      if (GadgetNum != 0) hash ^= GadgetNum.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (DynamicGroupNum != 0) hash ^= DynamicGroupNum.GetHashCode();
      if (GroupNum != 0) hash ^= GroupNum.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (EntityNum != 0) hash ^= EntityNum.GetHashCode();
      if (GatherNum != 0) hash ^= GatherNum.GetHashCode();
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
      if (GatherNumInsight != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GatherNumInsight);
      }
      if (GroupNum != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GroupNum);
      }
      if (pos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Pos);
      }
      if (GadgetNum != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GadgetNum);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      if (EntityNum != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EntityNum);
      }
      if (MonsterNum != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MonsterNum);
      }
      if (DynamicGroupNum != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DynamicGroupNum);
      }
      if (GatherNum != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GatherNum);
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
      if (GatherNumInsight != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GatherNumInsight);
      }
      if (GroupNum != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GroupNum);
      }
      if (pos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Pos);
      }
      if (GadgetNum != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GadgetNum);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      if (EntityNum != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EntityNum);
      }
      if (MonsterNum != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MonsterNum);
      }
      if (DynamicGroupNum != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DynamicGroupNum);
      }
      if (GatherNum != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GatherNum);
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
      if (MonsterNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MonsterNum);
      }
      if (GatherNumInsight != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GatherNumInsight);
      }
      if (GadgetNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetNum);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (DynamicGroupNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DynamicGroupNum);
      }
      if (GroupNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupNum);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (EntityNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityNum);
      }
      if (GatherNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GatherNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetScenePerformanceRsp other) {
      if (other == null) {
        return;
      }
      if (other.MonsterNum != 0) {
        MonsterNum = other.MonsterNum;
      }
      if (other.GatherNumInsight != 0) {
        GatherNumInsight = other.GatherNumInsight;
      }
      if (other.GadgetNum != 0) {
        GadgetNum = other.GadgetNum;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.DynamicGroupNum != 0) {
        DynamicGroupNum = other.DynamicGroupNum;
      }
      if (other.GroupNum != 0) {
        GroupNum = other.GroupNum;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.EntityNum != 0) {
        EntityNum = other.EntityNum;
      }
      if (other.GatherNum != 0) {
        GatherNum = other.GatherNum;
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
          case 8: {
            GatherNumInsight = input.ReadUInt32();
            break;
          }
          case 16: {
            GroupNum = input.ReadUInt32();
            break;
          }
          case 34: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 48: {
            GadgetNum = input.ReadUInt32();
            break;
          }
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 64: {
            EntityNum = input.ReadUInt32();
            break;
          }
          case 72: {
            MonsterNum = input.ReadUInt32();
            break;
          }
          case 96: {
            DynamicGroupNum = input.ReadUInt32();
            break;
          }
          case 104: {
            GatherNum = input.ReadUInt32();
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
          case 8: {
            GatherNumInsight = input.ReadUInt32();
            break;
          }
          case 16: {
            GroupNum = input.ReadUInt32();
            break;
          }
          case 34: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 48: {
            GadgetNum = input.ReadUInt32();
            break;
          }
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 64: {
            EntityNum = input.ReadUInt32();
            break;
          }
          case 72: {
            MonsterNum = input.ReadUInt32();
            break;
          }
          case 96: {
            DynamicGroupNum = input.ReadUInt32();
            break;
          }
          case 104: {
            GatherNum = input.ReadUInt32();
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
