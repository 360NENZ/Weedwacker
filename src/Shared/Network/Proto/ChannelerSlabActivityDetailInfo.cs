// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChannelerSlabActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ChannelerSlabActivityDetailInfo.proto</summary>
  public static partial class ChannelerSlabActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChannelerSlabActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChannelerSlabActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVDaGFubmVsZXJTbGFiQWN0aXZpdHlEZXRhaWxJbmZvLnByb3RvGhtDaGFu",
            "bmVsZXJTbGFiQnVmZkluZm8ucHJvdG8aIUNoYW5uZWxlclNsYWJDaGFsbGVu",
            "Z2VTdGFnZS5wcm90bxonQ2hhbm5lbGVyU2xhYkxvb3BEdW5nZW9uU3RhZ2VJ",
            "bmZvLnByb3RvItoBCh9DaGFubmVsZXJTbGFiQWN0aXZpdHlEZXRhaWxJbmZv",
            "EikKCWJ1ZmZfaW5mbxgBIAEoCzIWLkNoYW5uZWxlclNsYWJCdWZmSW5mbxJD",
            "Chdsb29wX2R1bmdlb25fc3RhZ2VfaW5mbxgHIAEoCzIiLkNoYW5uZWxlclNs",
            "YWJMb29wRHVuZ2VvblN0YWdlSW5mbxIwCgpzdGFnZV9saXN0GA8gAygLMhwu",
            "Q2hhbm5lbGVyU2xhYkNoYWxsZW5nZVN0YWdlEhUKDXBsYXlfZW5kX3RpbWUY",
            "AyABKA1CIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ChannelerSlabBuffInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ChannelerSlabChallengeStageReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ChannelerSlabLoopDungeonStageInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ChannelerSlabActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.ChannelerSlabActivityDetailInfo.Parser, new[]{ "BuffInfo", "LoopDungeonStageInfo", "StageList", "PlayEndTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChannelerSlabActivityDetailInfo : pb::IMessage<ChannelerSlabActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChannelerSlabActivityDetailInfo> _parser = new pb::MessageParser<ChannelerSlabActivityDetailInfo>(() => new ChannelerSlabActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChannelerSlabActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ChannelerSlabActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabActivityDetailInfo(ChannelerSlabActivityDetailInfo other) : this() {
      buffInfo_ = other.buffInfo_ != null ? other.buffInfo_.Clone() : null;
      loopDungeonStageInfo_ = other.loopDungeonStageInfo_ != null ? other.loopDungeonStageInfo_.Clone() : null;
      stageList_ = other.stageList_.Clone();
      playEndTime_ = other.playEndTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabActivityDetailInfo Clone() {
      return new ChannelerSlabActivityDetailInfo(this);
    }

    /// <summary>Field number for the "buff_info" field.</summary>
    public const int BuffInfoFieldNumber = 1;
    private global::Weedwacker.Shared.Network.Proto.ChannelerSlabBuffInfo buffInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ChannelerSlabBuffInfo BuffInfo {
      get { return buffInfo_; }
      set {
        buffInfo_ = value;
      }
    }

    /// <summary>Field number for the "loop_dungeon_stage_info" field.</summary>
    public const int LoopDungeonStageInfoFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.ChannelerSlabLoopDungeonStageInfo loopDungeonStageInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ChannelerSlabLoopDungeonStageInfo LoopDungeonStageInfo {
      get { return loopDungeonStageInfo_; }
      set {
        loopDungeonStageInfo_ = value;
      }
    }

    /// <summary>Field number for the "stage_list" field.</summary>
    public const int StageListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ChannelerSlabChallengeStage> _repeated_stageList_codec
        = pb::FieldCodec.ForMessage(122, global::Weedwacker.Shared.Network.Proto.ChannelerSlabChallengeStage.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ChannelerSlabChallengeStage> stageList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ChannelerSlabChallengeStage>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ChannelerSlabChallengeStage> StageList {
      get { return stageList_; }
    }

    /// <summary>Field number for the "play_end_time" field.</summary>
    public const int PlayEndTimeFieldNumber = 3;
    private uint playEndTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayEndTime {
      get { return playEndTime_; }
      set {
        playEndTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChannelerSlabActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChannelerSlabActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BuffInfo, other.BuffInfo)) return false;
      if (!object.Equals(LoopDungeonStageInfo, other.LoopDungeonStageInfo)) return false;
      if(!stageList_.Equals(other.stageList_)) return false;
      if (PlayEndTime != other.PlayEndTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (buffInfo_ != null) hash ^= BuffInfo.GetHashCode();
      if (loopDungeonStageInfo_ != null) hash ^= LoopDungeonStageInfo.GetHashCode();
      hash ^= stageList_.GetHashCode();
      if (PlayEndTime != 0) hash ^= PlayEndTime.GetHashCode();
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
      if (buffInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BuffInfo);
      }
      if (PlayEndTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PlayEndTime);
      }
      if (loopDungeonStageInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(LoopDungeonStageInfo);
      }
      stageList_.WriteTo(output, _repeated_stageList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (buffInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BuffInfo);
      }
      if (PlayEndTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PlayEndTime);
      }
      if (loopDungeonStageInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(LoopDungeonStageInfo);
      }
      stageList_.WriteTo(ref output, _repeated_stageList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (buffInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BuffInfo);
      }
      if (loopDungeonStageInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LoopDungeonStageInfo);
      }
      size += stageList_.CalculateSize(_repeated_stageList_codec);
      if (PlayEndTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayEndTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChannelerSlabActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.buffInfo_ != null) {
        if (buffInfo_ == null) {
          BuffInfo = new global::Weedwacker.Shared.Network.Proto.ChannelerSlabBuffInfo();
        }
        BuffInfo.MergeFrom(other.BuffInfo);
      }
      if (other.loopDungeonStageInfo_ != null) {
        if (loopDungeonStageInfo_ == null) {
          LoopDungeonStageInfo = new global::Weedwacker.Shared.Network.Proto.ChannelerSlabLoopDungeonStageInfo();
        }
        LoopDungeonStageInfo.MergeFrom(other.LoopDungeonStageInfo);
      }
      stageList_.Add(other.stageList_);
      if (other.PlayEndTime != 0) {
        PlayEndTime = other.PlayEndTime;
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
          case 10: {
            if (buffInfo_ == null) {
              BuffInfo = new global::Weedwacker.Shared.Network.Proto.ChannelerSlabBuffInfo();
            }
            input.ReadMessage(BuffInfo);
            break;
          }
          case 24: {
            PlayEndTime = input.ReadUInt32();
            break;
          }
          case 58: {
            if (loopDungeonStageInfo_ == null) {
              LoopDungeonStageInfo = new global::Weedwacker.Shared.Network.Proto.ChannelerSlabLoopDungeonStageInfo();
            }
            input.ReadMessage(LoopDungeonStageInfo);
            break;
          }
          case 122: {
            stageList_.AddEntriesFrom(input, _repeated_stageList_codec);
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
          case 10: {
            if (buffInfo_ == null) {
              BuffInfo = new global::Weedwacker.Shared.Network.Proto.ChannelerSlabBuffInfo();
            }
            input.ReadMessage(BuffInfo);
            break;
          }
          case 24: {
            PlayEndTime = input.ReadUInt32();
            break;
          }
          case 58: {
            if (loopDungeonStageInfo_ == null) {
              LoopDungeonStageInfo = new global::Weedwacker.Shared.Network.Proto.ChannelerSlabLoopDungeonStageInfo();
            }
            input.ReadMessage(LoopDungeonStageInfo);
            break;
          }
          case 122: {
            stageList_.AddEntriesFrom(ref input, _repeated_stageList_codec);
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
