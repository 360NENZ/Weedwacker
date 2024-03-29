// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InBattleMechanicusSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from InBattleMechanicusSettleInfo.proto</summary>
  public static partial class InBattleMechanicusSettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for InBattleMechanicusSettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InBattleMechanicusSettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJJbkJhdHRsZU1lY2hhbmljdXNTZXR0bGVJbmZvLnByb3RvGiFNdWx0aXN0",
            "YWdlU2V0dGxlV2F0Y2hlckluZm8ucHJvdG8i6wEKHEluQmF0dGxlTWVjaGFu",
            "aWN1c1NldHRsZUluZm8SFQoNc2NlbmVfdGltZV9tcxgPIAEoBBITCgt0b3Rh",
            "bF90b2tlbhgEIAEoDRISCgpyZWFsX3Rva2VuGAggASgNEjIKDHdhdGNoZXJf",
            "bGlzdBgHIAMoCzIcLk11bHRpc3RhZ2VTZXR0bGVXYXRjaGVySW5mbxISCgpp",
            "c19zdWNjZXNzGAYgASgIEhIKCnBsYXlfaW5kZXgYAyABKA0SHQoVZGlmZmlj",
            "dWx0eV9wZXJjZW50YWdlGAogASgNEhAKCGdyb3VwX2lkGA0gASgNQiKqAh9X",
            "ZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.MultistageSettleWatcherInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.InBattleMechanicusSettleInfo), global::Weedwacker.Shared.Network.Proto.InBattleMechanicusSettleInfo.Parser, new[]{ "SceneTimeMs", "TotalToken", "RealToken", "WatcherList", "IsSuccess", "PlayIndex", "DifficultyPercentage", "GroupId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InBattleMechanicusSettleInfo : pb::IMessage<InBattleMechanicusSettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InBattleMechanicusSettleInfo> _parser = new pb::MessageParser<InBattleMechanicusSettleInfo>(() => new InBattleMechanicusSettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InBattleMechanicusSettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.InBattleMechanicusSettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleMechanicusSettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleMechanicusSettleInfo(InBattleMechanicusSettleInfo other) : this() {
      sceneTimeMs_ = other.sceneTimeMs_;
      totalToken_ = other.totalToken_;
      realToken_ = other.realToken_;
      watcherList_ = other.watcherList_.Clone();
      isSuccess_ = other.isSuccess_;
      playIndex_ = other.playIndex_;
      difficultyPercentage_ = other.difficultyPercentage_;
      groupId_ = other.groupId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleMechanicusSettleInfo Clone() {
      return new InBattleMechanicusSettleInfo(this);
    }

    /// <summary>Field number for the "scene_time_ms" field.</summary>
    public const int SceneTimeMsFieldNumber = 15;
    private ulong sceneTimeMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong SceneTimeMs {
      get { return sceneTimeMs_; }
      set {
        sceneTimeMs_ = value;
      }
    }

    /// <summary>Field number for the "total_token" field.</summary>
    public const int TotalTokenFieldNumber = 4;
    private uint totalToken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalToken {
      get { return totalToken_; }
      set {
        totalToken_ = value;
      }
    }

    /// <summary>Field number for the "real_token" field.</summary>
    public const int RealTokenFieldNumber = 8;
    private uint realToken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RealToken {
      get { return realToken_; }
      set {
        realToken_ = value;
      }
    }

    /// <summary>Field number for the "watcher_list" field.</summary>
    public const int WatcherListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.MultistageSettleWatcherInfo> _repeated_watcherList_codec
        = pb::FieldCodec.ForMessage(58, global::Weedwacker.Shared.Network.Proto.MultistageSettleWatcherInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.MultistageSettleWatcherInfo> watcherList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.MultistageSettleWatcherInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.MultistageSettleWatcherInfo> WatcherList {
      get { return watcherList_; }
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 6;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "play_index" field.</summary>
    public const int PlayIndexFieldNumber = 3;
    private uint playIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayIndex {
      get { return playIndex_; }
      set {
        playIndex_ = value;
      }
    }

    /// <summary>Field number for the "difficulty_percentage" field.</summary>
    public const int DifficultyPercentageFieldNumber = 10;
    private uint difficultyPercentage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DifficultyPercentage {
      get { return difficultyPercentage_; }
      set {
        difficultyPercentage_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 13;
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
      return Equals(other as InBattleMechanicusSettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InBattleMechanicusSettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SceneTimeMs != other.SceneTimeMs) return false;
      if (TotalToken != other.TotalToken) return false;
      if (RealToken != other.RealToken) return false;
      if(!watcherList_.Equals(other.watcherList_)) return false;
      if (IsSuccess != other.IsSuccess) return false;
      if (PlayIndex != other.PlayIndex) return false;
      if (DifficultyPercentage != other.DifficultyPercentage) return false;
      if (GroupId != other.GroupId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SceneTimeMs != 0UL) hash ^= SceneTimeMs.GetHashCode();
      if (TotalToken != 0) hash ^= TotalToken.GetHashCode();
      if (RealToken != 0) hash ^= RealToken.GetHashCode();
      hash ^= watcherList_.GetHashCode();
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (PlayIndex != 0) hash ^= PlayIndex.GetHashCode();
      if (DifficultyPercentage != 0) hash ^= DifficultyPercentage.GetHashCode();
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
      if (PlayIndex != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PlayIndex);
      }
      if (TotalToken != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TotalToken);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsSuccess);
      }
      watcherList_.WriteTo(output, _repeated_watcherList_codec);
      if (RealToken != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RealToken);
      }
      if (DifficultyPercentage != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DifficultyPercentage);
      }
      if (GroupId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GroupId);
      }
      if (SceneTimeMs != 0UL) {
        output.WriteRawTag(120);
        output.WriteUInt64(SceneTimeMs);
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
      if (PlayIndex != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PlayIndex);
      }
      if (TotalToken != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TotalToken);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsSuccess);
      }
      watcherList_.WriteTo(ref output, _repeated_watcherList_codec);
      if (RealToken != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RealToken);
      }
      if (DifficultyPercentage != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DifficultyPercentage);
      }
      if (GroupId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GroupId);
      }
      if (SceneTimeMs != 0UL) {
        output.WriteRawTag(120);
        output.WriteUInt64(SceneTimeMs);
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
      if (SceneTimeMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(SceneTimeMs);
      }
      if (TotalToken != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalToken);
      }
      if (RealToken != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RealToken);
      }
      size += watcherList_.CalculateSize(_repeated_watcherList_codec);
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (PlayIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayIndex);
      }
      if (DifficultyPercentage != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyPercentage);
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
    public void MergeFrom(InBattleMechanicusSettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.SceneTimeMs != 0UL) {
        SceneTimeMs = other.SceneTimeMs;
      }
      if (other.TotalToken != 0) {
        TotalToken = other.TotalToken;
      }
      if (other.RealToken != 0) {
        RealToken = other.RealToken;
      }
      watcherList_.Add(other.watcherList_);
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.PlayIndex != 0) {
        PlayIndex = other.PlayIndex;
      }
      if (other.DifficultyPercentage != 0) {
        DifficultyPercentage = other.DifficultyPercentage;
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
            PlayIndex = input.ReadUInt32();
            break;
          }
          case 32: {
            TotalToken = input.ReadUInt32();
            break;
          }
          case 48: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 58: {
            watcherList_.AddEntriesFrom(input, _repeated_watcherList_codec);
            break;
          }
          case 64: {
            RealToken = input.ReadUInt32();
            break;
          }
          case 80: {
            DifficultyPercentage = input.ReadUInt32();
            break;
          }
          case 104: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 120: {
            SceneTimeMs = input.ReadUInt64();
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
            PlayIndex = input.ReadUInt32();
            break;
          }
          case 32: {
            TotalToken = input.ReadUInt32();
            break;
          }
          case 48: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 58: {
            watcherList_.AddEntriesFrom(ref input, _repeated_watcherList_codec);
            break;
          }
          case 64: {
            RealToken = input.ReadUInt32();
            break;
          }
          case 80: {
            DifficultyPercentage = input.ReadUInt32();
            break;
          }
          case 104: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 120: {
            SceneTimeMs = input.ReadUInt64();
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
