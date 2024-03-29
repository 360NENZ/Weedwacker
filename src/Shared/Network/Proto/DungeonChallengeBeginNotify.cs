// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonChallengeBeginNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from DungeonChallengeBeginNotify.proto</summary>
  public static partial class DungeonChallengeBeginNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonChallengeBeginNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonChallengeBeginNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFEdW5nZW9uQ2hhbGxlbmdlQmVnaW5Ob3RpZnkucHJvdG8imgEKG0R1bmdl",
            "b25DaGFsbGVuZ2VCZWdpbk5vdGlmeRIUCgxmYXRoZXJfaW5kZXgYBSABKA0S",
            "EgoKcGFyYW1fbGlzdBgOIAMoDRIXCg9jaGFsbGVuZ2VfaW5kZXgYBiABKA0S",
            "FAoMY2hhbGxlbmdlX2lkGAEgASgNEhAKCGdyb3VwX2lkGAQgASgNEhAKCHVp",
            "ZF9saXN0GAwgAygNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.DungeonChallengeBeginNotify), global::Weedwacker.Shared.Network.Proto.DungeonChallengeBeginNotify.Parser, new[]{ "FatherIndex", "ParamList", "ChallengeIndex", "ChallengeId", "GroupId", "UidList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 947
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class DungeonChallengeBeginNotify : pb::IMessage<DungeonChallengeBeginNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DungeonChallengeBeginNotify> _parser = new pb::MessageParser<DungeonChallengeBeginNotify>(() => new DungeonChallengeBeginNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DungeonChallengeBeginNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.DungeonChallengeBeginNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonChallengeBeginNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonChallengeBeginNotify(DungeonChallengeBeginNotify other) : this() {
      fatherIndex_ = other.fatherIndex_;
      paramList_ = other.paramList_.Clone();
      challengeIndex_ = other.challengeIndex_;
      challengeId_ = other.challengeId_;
      groupId_ = other.groupId_;
      uidList_ = other.uidList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonChallengeBeginNotify Clone() {
      return new DungeonChallengeBeginNotify(this);
    }

    /// <summary>Field number for the "father_index" field.</summary>
    public const int FatherIndexFieldNumber = 5;
    private uint fatherIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FatherIndex {
      get { return fatherIndex_; }
      set {
        fatherIndex_ = value;
      }
    }

    /// <summary>Field number for the "param_list" field.</summary>
    public const int ParamListFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_paramList_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> paramList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ParamList {
      get { return paramList_; }
    }

    /// <summary>Field number for the "challenge_index" field.</summary>
    public const int ChallengeIndexFieldNumber = 6;
    private uint challengeIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeIndex {
      get { return challengeIndex_; }
      set {
        challengeIndex_ = value;
      }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 1;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 4;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "uid_list" field.</summary>
    public const int UidListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_uidList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> uidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UidList {
      get { return uidList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DungeonChallengeBeginNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DungeonChallengeBeginNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FatherIndex != other.FatherIndex) return false;
      if(!paramList_.Equals(other.paramList_)) return false;
      if (ChallengeIndex != other.ChallengeIndex) return false;
      if (ChallengeId != other.ChallengeId) return false;
      if (GroupId != other.GroupId) return false;
      if(!uidList_.Equals(other.uidList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FatherIndex != 0) hash ^= FatherIndex.GetHashCode();
      hash ^= paramList_.GetHashCode();
      if (ChallengeIndex != 0) hash ^= ChallengeIndex.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      hash ^= uidList_.GetHashCode();
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
      if (ChallengeId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChallengeId);
      }
      if (GroupId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GroupId);
      }
      if (FatherIndex != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FatherIndex);
      }
      if (ChallengeIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ChallengeIndex);
      }
      uidList_.WriteTo(output, _repeated_uidList_codec);
      paramList_.WriteTo(output, _repeated_paramList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ChallengeId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChallengeId);
      }
      if (GroupId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GroupId);
      }
      if (FatherIndex != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FatherIndex);
      }
      if (ChallengeIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ChallengeIndex);
      }
      uidList_.WriteTo(ref output, _repeated_uidList_codec);
      paramList_.WriteTo(ref output, _repeated_paramList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (FatherIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FatherIndex);
      }
      size += paramList_.CalculateSize(_repeated_paramList_codec);
      if (ChallengeIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeIndex);
      }
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      size += uidList_.CalculateSize(_repeated_uidList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DungeonChallengeBeginNotify other) {
      if (other == null) {
        return;
      }
      if (other.FatherIndex != 0) {
        FatherIndex = other.FatherIndex;
      }
      paramList_.Add(other.paramList_);
      if (other.ChallengeIndex != 0) {
        ChallengeIndex = other.ChallengeIndex;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      uidList_.Add(other.uidList_);
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
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 32: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 40: {
            FatherIndex = input.ReadUInt32();
            break;
          }
          case 48: {
            ChallengeIndex = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            uidList_.AddEntriesFrom(input, _repeated_uidList_codec);
            break;
          }
          case 114:
          case 112: {
            paramList_.AddEntriesFrom(input, _repeated_paramList_codec);
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
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 32: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 40: {
            FatherIndex = input.ReadUInt32();
            break;
          }
          case 48: {
            ChallengeIndex = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            uidList_.AddEntriesFrom(ref input, _repeated_uidList_codec);
            break;
          }
          case 114:
          case 112: {
            paramList_.AddEntriesFrom(ref input, _repeated_paramList_codec);
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
