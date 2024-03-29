// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ExpeditionPathInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ExpeditionPathInfo.proto</summary>
  public static partial class ExpeditionPathInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ExpeditionPathInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExpeditionPathInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhFeHBlZGl0aW9uUGF0aEluZm8ucHJvdG8aFUV4cGVkaXRpb25TdGF0ZS5w",
            "cm90byL9AQoSRXhwZWRpdGlvblBhdGhJbmZvEg8KB21hcmtfaWQYDCABKA0S",
            "EgoKc3RhcnRfdGltZRgJIAEoDRIYChBhc3Npc3RfYXZhdGFyX2lkGAcgASgN",
            "EhkKEWJvbnVzX3Byb2JhYmlsaXR5GAQgASgCEh8KBXN0YXRlGA8gASgOMhAu",
            "RXhwZWRpdGlvblN0YXRlEhYKDmF2YXRhcl9pZF9saXN0GAIgAygNEhkKEWFz",
            "c2lzdF9jb3N0dW1lX2lkGAUgASgNEg8KB3BhdGhfaWQYCCABKA0SFAoMY2hh",
            "bGxlbmdlX2lkGAsgASgNEhIKCmFzc2lzdF91aWQYCiABKA1CIqoCH1dlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ExpeditionStateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ExpeditionPathInfo), global::Weedwacker.Shared.Network.Proto.ExpeditionPathInfo.Parser, new[]{ "MarkId", "StartTime", "AssistAvatarId", "BonusProbability", "State", "AvatarIdList", "AssistCostumeId", "PathId", "ChallengeId", "AssistUid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ExpeditionPathInfo : pb::IMessage<ExpeditionPathInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExpeditionPathInfo> _parser = new pb::MessageParser<ExpeditionPathInfo>(() => new ExpeditionPathInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExpeditionPathInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ExpeditionPathInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExpeditionPathInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExpeditionPathInfo(ExpeditionPathInfo other) : this() {
      markId_ = other.markId_;
      startTime_ = other.startTime_;
      assistAvatarId_ = other.assistAvatarId_;
      bonusProbability_ = other.bonusProbability_;
      state_ = other.state_;
      avatarIdList_ = other.avatarIdList_.Clone();
      assistCostumeId_ = other.assistCostumeId_;
      pathId_ = other.pathId_;
      challengeId_ = other.challengeId_;
      assistUid_ = other.assistUid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExpeditionPathInfo Clone() {
      return new ExpeditionPathInfo(this);
    }

    /// <summary>Field number for the "mark_id" field.</summary>
    public const int MarkIdFieldNumber = 12;
    private uint markId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MarkId {
      get { return markId_; }
      set {
        markId_ = value;
      }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 9;
    private uint startTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "assist_avatar_id" field.</summary>
    public const int AssistAvatarIdFieldNumber = 7;
    private uint assistAvatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AssistAvatarId {
      get { return assistAvatarId_; }
      set {
        assistAvatarId_ = value;
      }
    }

    /// <summary>Field number for the "bonus_probability" field.</summary>
    public const int BonusProbabilityFieldNumber = 4;
    private float bonusProbability_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float BonusProbability {
      get { return bonusProbability_; }
      set {
        bonusProbability_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 15;
    private global::Weedwacker.Shared.Network.Proto.ExpeditionState state_ = global::Weedwacker.Shared.Network.Proto.ExpeditionState.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ExpeditionState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "avatar_id_list" field.</summary>
    public const int AvatarIdListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_avatarIdList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> avatarIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AvatarIdList {
      get { return avatarIdList_; }
    }

    /// <summary>Field number for the "assist_costume_id" field.</summary>
    public const int AssistCostumeIdFieldNumber = 5;
    private uint assistCostumeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AssistCostumeId {
      get { return assistCostumeId_; }
      set {
        assistCostumeId_ = value;
      }
    }

    /// <summary>Field number for the "path_id" field.</summary>
    public const int PathIdFieldNumber = 8;
    private uint pathId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PathId {
      get { return pathId_; }
      set {
        pathId_ = value;
      }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 11;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    /// <summary>Field number for the "assist_uid" field.</summary>
    public const int AssistUidFieldNumber = 10;
    private uint assistUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AssistUid {
      get { return assistUid_; }
      set {
        assistUid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExpeditionPathInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExpeditionPathInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MarkId != other.MarkId) return false;
      if (StartTime != other.StartTime) return false;
      if (AssistAvatarId != other.AssistAvatarId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BonusProbability, other.BonusProbability)) return false;
      if (State != other.State) return false;
      if(!avatarIdList_.Equals(other.avatarIdList_)) return false;
      if (AssistCostumeId != other.AssistCostumeId) return false;
      if (PathId != other.PathId) return false;
      if (ChallengeId != other.ChallengeId) return false;
      if (AssistUid != other.AssistUid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MarkId != 0) hash ^= MarkId.GetHashCode();
      if (StartTime != 0) hash ^= StartTime.GetHashCode();
      if (AssistAvatarId != 0) hash ^= AssistAvatarId.GetHashCode();
      if (BonusProbability != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BonusProbability);
      if (State != global::Weedwacker.Shared.Network.Proto.ExpeditionState.None) hash ^= State.GetHashCode();
      hash ^= avatarIdList_.GetHashCode();
      if (AssistCostumeId != 0) hash ^= AssistCostumeId.GetHashCode();
      if (PathId != 0) hash ^= PathId.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
      if (AssistUid != 0) hash ^= AssistUid.GetHashCode();
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
      avatarIdList_.WriteTo(output, _repeated_avatarIdList_codec);
      if (BonusProbability != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(BonusProbability);
      }
      if (AssistCostumeId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(AssistCostumeId);
      }
      if (AssistAvatarId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(AssistAvatarId);
      }
      if (PathId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PathId);
      }
      if (StartTime != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(StartTime);
      }
      if (AssistUid != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(AssistUid);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ChallengeId);
      }
      if (MarkId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MarkId);
      }
      if (State != global::Weedwacker.Shared.Network.Proto.ExpeditionState.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) State);
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
      avatarIdList_.WriteTo(ref output, _repeated_avatarIdList_codec);
      if (BonusProbability != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(BonusProbability);
      }
      if (AssistCostumeId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(AssistCostumeId);
      }
      if (AssistAvatarId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(AssistAvatarId);
      }
      if (PathId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PathId);
      }
      if (StartTime != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(StartTime);
      }
      if (AssistUid != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(AssistUid);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ChallengeId);
      }
      if (MarkId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MarkId);
      }
      if (State != global::Weedwacker.Shared.Network.Proto.ExpeditionState.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) State);
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
      if (MarkId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MarkId);
      }
      if (StartTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartTime);
      }
      if (AssistAvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AssistAvatarId);
      }
      if (BonusProbability != 0F) {
        size += 1 + 4;
      }
      if (State != global::Weedwacker.Shared.Network.Proto.ExpeditionState.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      size += avatarIdList_.CalculateSize(_repeated_avatarIdList_codec);
      if (AssistCostumeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AssistCostumeId);
      }
      if (PathId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PathId);
      }
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (AssistUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AssistUid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExpeditionPathInfo other) {
      if (other == null) {
        return;
      }
      if (other.MarkId != 0) {
        MarkId = other.MarkId;
      }
      if (other.StartTime != 0) {
        StartTime = other.StartTime;
      }
      if (other.AssistAvatarId != 0) {
        AssistAvatarId = other.AssistAvatarId;
      }
      if (other.BonusProbability != 0F) {
        BonusProbability = other.BonusProbability;
      }
      if (other.State != global::Weedwacker.Shared.Network.Proto.ExpeditionState.None) {
        State = other.State;
      }
      avatarIdList_.Add(other.avatarIdList_);
      if (other.AssistCostumeId != 0) {
        AssistCostumeId = other.AssistCostumeId;
      }
      if (other.PathId != 0) {
        PathId = other.PathId;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
      }
      if (other.AssistUid != 0) {
        AssistUid = other.AssistUid;
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
          case 18:
          case 16: {
            avatarIdList_.AddEntriesFrom(input, _repeated_avatarIdList_codec);
            break;
          }
          case 37: {
            BonusProbability = input.ReadFloat();
            break;
          }
          case 40: {
            AssistCostumeId = input.ReadUInt32();
            break;
          }
          case 56: {
            AssistAvatarId = input.ReadUInt32();
            break;
          }
          case 64: {
            PathId = input.ReadUInt32();
            break;
          }
          case 72: {
            StartTime = input.ReadUInt32();
            break;
          }
          case 80: {
            AssistUid = input.ReadUInt32();
            break;
          }
          case 88: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 96: {
            MarkId = input.ReadUInt32();
            break;
          }
          case 120: {
            State = (global::Weedwacker.Shared.Network.Proto.ExpeditionState) input.ReadEnum();
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
            avatarIdList_.AddEntriesFrom(ref input, _repeated_avatarIdList_codec);
            break;
          }
          case 37: {
            BonusProbability = input.ReadFloat();
            break;
          }
          case 40: {
            AssistCostumeId = input.ReadUInt32();
            break;
          }
          case 56: {
            AssistAvatarId = input.ReadUInt32();
            break;
          }
          case 64: {
            PathId = input.ReadUInt32();
            break;
          }
          case 72: {
            StartTime = input.ReadUInt32();
            break;
          }
          case 80: {
            AssistUid = input.ReadUInt32();
            break;
          }
          case 88: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 96: {
            MarkId = input.ReadUInt32();
            break;
          }
          case 120: {
            State = (global::Weedwacker.Shared.Network.Proto.ExpeditionState) input.ReadEnum();
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
