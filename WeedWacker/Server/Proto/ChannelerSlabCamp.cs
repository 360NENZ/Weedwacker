// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChannelerSlabCamp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from ChannelerSlabCamp.proto</summary>
  public static partial class ChannelerSlabCampReflection {

    #region Descriptor
    /// <summary>File descriptor for ChannelerSlabCamp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChannelerSlabCampReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdDaGFubmVsZXJTbGFiQ2FtcC5wcm90bxoMVmVjdG9yLnByb3RvImAKEUNo",
            "YW5uZWxlclNsYWJDYW1wEhEKCXJld2FyZF9pZBgLIAEoDRIUCgNwb3MYCCAB",
            "KAsyBy5WZWN0b3ISEAoIYnVmZl9udW0YByABKA0SEAoIZ3JvdXBfaWQYAyAB",
            "KA1CGqoCF1dlZWR3YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.ChannelerSlabCamp), global::Weedwacker.Server.Proto.ChannelerSlabCamp.Parser, new[]{ "RewardId", "Pos", "BuffNum", "GroupId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChannelerSlabCamp : pb::IMessage<ChannelerSlabCamp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChannelerSlabCamp> _parser = new pb::MessageParser<ChannelerSlabCamp>(() => new ChannelerSlabCamp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChannelerSlabCamp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.ChannelerSlabCampReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabCamp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabCamp(ChannelerSlabCamp other) : this() {
      rewardId_ = other.rewardId_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      buffNum_ = other.buffNum_;
      groupId_ = other.groupId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabCamp Clone() {
      return new ChannelerSlabCamp(this);
    }

    /// <summary>Field number for the "reward_id" field.</summary>
    public const int RewardIdFieldNumber = 11;
    private uint rewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RewardId {
      get { return rewardId_; }
      set {
        rewardId_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 8;
    private global::Weedwacker.Server.Proto.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "buff_num" field.</summary>
    public const int BuffNumFieldNumber = 7;
    private uint buffNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuffNum {
      get { return buffNum_; }
      set {
        buffNum_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 3;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChannelerSlabCamp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChannelerSlabCamp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RewardId != other.RewardId) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (BuffNum != other.BuffNum) return false;
      if (GroupId != other.GroupId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RewardId != 0) hash ^= RewardId.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (BuffNum != 0) hash ^= BuffNum.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
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
      if (GroupId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GroupId);
      }
      if (BuffNum != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(BuffNum);
      }
      if (pos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Pos);
      }
      if (RewardId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(RewardId);
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
      if (GroupId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GroupId);
      }
      if (BuffNum != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(BuffNum);
      }
      if (pos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Pos);
      }
      if (RewardId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(RewardId);
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
      if (RewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RewardId);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (BuffNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuffNum);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChannelerSlabCamp other) {
      if (other == null) {
        return;
      }
      if (other.RewardId != 0) {
        RewardId = other.RewardId;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::Weedwacker.Server.Proto.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.BuffNum != 0) {
        BuffNum = other.BuffNum;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
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
          case 24: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 56: {
            BuffNum = input.ReadUInt32();
            break;
          }
          case 66: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 88: {
            RewardId = input.ReadUInt32();
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
          case 24: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 56: {
            BuffNum = input.ReadUInt32();
            break;
          }
          case 66: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 88: {
            RewardId = input.ReadUInt32();
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