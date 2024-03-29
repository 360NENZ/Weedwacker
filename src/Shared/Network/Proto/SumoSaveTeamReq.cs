// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SumoSaveTeamReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SumoSaveTeamReq.proto</summary>
  public static partial class SumoSaveTeamReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SumoSaveTeamReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SumoSaveTeamReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVTdW1vU2F2ZVRlYW1SZXEucHJvdG8aElN1bW9UZWFtRGF0YS5wcm90byJx",
            "Cg9TdW1vU2F2ZVRlYW1SZXESEwoLYWN0aXZpdHlfaWQYCyABKA0SEAoIc3Rh",
            "Z2VfaWQYDSABKA0SFQoNZGlmZmljdWx0eV9pZBgHIAEoDRIgCgl0ZWFtX2xp",
            "c3QYDCADKAsyDS5TdW1vVGVhbURhdGFCIqoCH1dlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.SumoTeamDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SumoSaveTeamReq), global::Weedwacker.Shared.Network.Proto.SumoSaveTeamReq.Parser, new[]{ "ActivityId", "StageId", "DifficultyId", "TeamList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8313
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class SumoSaveTeamReq : pb::IMessage<SumoSaveTeamReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SumoSaveTeamReq> _parser = new pb::MessageParser<SumoSaveTeamReq>(() => new SumoSaveTeamReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SumoSaveTeamReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SumoSaveTeamReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoSaveTeamReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoSaveTeamReq(SumoSaveTeamReq other) : this() {
      activityId_ = other.activityId_;
      stageId_ = other.stageId_;
      difficultyId_ = other.difficultyId_;
      teamList_ = other.teamList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoSaveTeamReq Clone() {
      return new SumoSaveTeamReq(this);
    }

    /// <summary>Field number for the "activity_id" field.</summary>
    public const int ActivityIdFieldNumber = 11;
    private uint activityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ActivityId {
      get { return activityId_; }
      set {
        activityId_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 13;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "difficulty_id" field.</summary>
    public const int DifficultyIdFieldNumber = 7;
    private uint difficultyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DifficultyId {
      get { return difficultyId_; }
      set {
        difficultyId_ = value;
      }
    }

    /// <summary>Field number for the "team_list" field.</summary>
    public const int TeamListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.SumoTeamData> _repeated_teamList_codec
        = pb::FieldCodec.ForMessage(98, global::Weedwacker.Shared.Network.Proto.SumoTeamData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SumoTeamData> teamList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SumoTeamData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SumoTeamData> TeamList {
      get { return teamList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SumoSaveTeamReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SumoSaveTeamReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ActivityId != other.ActivityId) return false;
      if (StageId != other.StageId) return false;
      if (DifficultyId != other.DifficultyId) return false;
      if(!teamList_.Equals(other.teamList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ActivityId != 0) hash ^= ActivityId.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
      hash ^= teamList_.GetHashCode();
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
      if (DifficultyId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(DifficultyId);
      }
      if (ActivityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ActivityId);
      }
      teamList_.WriteTo(output, _repeated_teamList_codec);
      if (StageId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(StageId);
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
      if (DifficultyId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(DifficultyId);
      }
      if (ActivityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ActivityId);
      }
      teamList_.WriteTo(ref output, _repeated_teamList_codec);
      if (StageId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(StageId);
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
      if (ActivityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ActivityId);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (DifficultyId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
      }
      size += teamList_.CalculateSize(_repeated_teamList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SumoSaveTeamReq other) {
      if (other == null) {
        return;
      }
      if (other.ActivityId != 0) {
        ActivityId = other.ActivityId;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.DifficultyId != 0) {
        DifficultyId = other.DifficultyId;
      }
      teamList_.Add(other.teamList_);
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
          case 56: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 88: {
            ActivityId = input.ReadUInt32();
            break;
          }
          case 98: {
            teamList_.AddEntriesFrom(input, _repeated_teamList_codec);
            break;
          }
          case 104: {
            StageId = input.ReadUInt32();
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
          case 56: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 88: {
            ActivityId = input.ReadUInt32();
            break;
          }
          case 98: {
            teamList_.AddEntriesFrom(ref input, _repeated_teamList_codec);
            break;
          }
          case 104: {
            StageId = input.ReadUInt32();
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
