// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SeaLampActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SeaLampActivityDetailInfo.proto</summary>
  public static partial class SeaLampActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SeaLampActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SeaLampActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9TZWFMYW1wQWN0aXZpdHlEZXRhaWxJbmZvLnByb3RvIrwBChlTZWFMYW1w",
            "QWN0aXZpdHlEZXRhaWxJbmZvEhAKCHBoYXNlX2lkGA4gASgNEh8KF3Rha2Vu",
            "X3BoYXNlX3Jld2FyZF9saXN0GAEgAygNEiYKHnRha2VuX2NvbnRyaWJ1dGlv",
            "bl9yZXdhcmRfbGlzdBgHIAMoDRIQCghwcm9ncmVzcxgIIAEoDRIUCgxjb250",
            "cmlidXRpb24YDyABKA0SDgoGZmFjdG9yGA0gASgNEgwKBGRheXMYBCABKA1C",
            "IqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SeaLampActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.SeaLampActivityDetailInfo.Parser, new[]{ "PhaseId", "TakenPhaseRewardList", "TakenContributionRewardList", "Progress", "Contribution", "Factor", "Days" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SeaLampActivityDetailInfo : pb::IMessage<SeaLampActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SeaLampActivityDetailInfo> _parser = new pb::MessageParser<SeaLampActivityDetailInfo>(() => new SeaLampActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SeaLampActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SeaLampActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SeaLampActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SeaLampActivityDetailInfo(SeaLampActivityDetailInfo other) : this() {
      phaseId_ = other.phaseId_;
      takenPhaseRewardList_ = other.takenPhaseRewardList_.Clone();
      takenContributionRewardList_ = other.takenContributionRewardList_.Clone();
      progress_ = other.progress_;
      contribution_ = other.contribution_;
      factor_ = other.factor_;
      days_ = other.days_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SeaLampActivityDetailInfo Clone() {
      return new SeaLampActivityDetailInfo(this);
    }

    /// <summary>Field number for the "phase_id" field.</summary>
    public const int PhaseIdFieldNumber = 14;
    private uint phaseId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PhaseId {
      get { return phaseId_; }
      set {
        phaseId_ = value;
      }
    }

    /// <summary>Field number for the "taken_phase_reward_list" field.</summary>
    public const int TakenPhaseRewardListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_takenPhaseRewardList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> takenPhaseRewardList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TakenPhaseRewardList {
      get { return takenPhaseRewardList_; }
    }

    /// <summary>Field number for the "taken_contribution_reward_list" field.</summary>
    public const int TakenContributionRewardListFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_takenContributionRewardList_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> takenContributionRewardList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TakenContributionRewardList {
      get { return takenContributionRewardList_; }
    }

    /// <summary>Field number for the "progress" field.</summary>
    public const int ProgressFieldNumber = 8;
    private uint progress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Progress {
      get { return progress_; }
      set {
        progress_ = value;
      }
    }

    /// <summary>Field number for the "contribution" field.</summary>
    public const int ContributionFieldNumber = 15;
    private uint contribution_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Contribution {
      get { return contribution_; }
      set {
        contribution_ = value;
      }
    }

    /// <summary>Field number for the "factor" field.</summary>
    public const int FactorFieldNumber = 13;
    private uint factor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Factor {
      get { return factor_; }
      set {
        factor_ = value;
      }
    }

    /// <summary>Field number for the "days" field.</summary>
    public const int DaysFieldNumber = 4;
    private uint days_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Days {
      get { return days_; }
      set {
        days_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SeaLampActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SeaLampActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PhaseId != other.PhaseId) return false;
      if(!takenPhaseRewardList_.Equals(other.takenPhaseRewardList_)) return false;
      if(!takenContributionRewardList_.Equals(other.takenContributionRewardList_)) return false;
      if (Progress != other.Progress) return false;
      if (Contribution != other.Contribution) return false;
      if (Factor != other.Factor) return false;
      if (Days != other.Days) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PhaseId != 0) hash ^= PhaseId.GetHashCode();
      hash ^= takenPhaseRewardList_.GetHashCode();
      hash ^= takenContributionRewardList_.GetHashCode();
      if (Progress != 0) hash ^= Progress.GetHashCode();
      if (Contribution != 0) hash ^= Contribution.GetHashCode();
      if (Factor != 0) hash ^= Factor.GetHashCode();
      if (Days != 0) hash ^= Days.GetHashCode();
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
      takenPhaseRewardList_.WriteTo(output, _repeated_takenPhaseRewardList_codec);
      if (Days != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Days);
      }
      takenContributionRewardList_.WriteTo(output, _repeated_takenContributionRewardList_codec);
      if (Progress != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Progress);
      }
      if (Factor != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Factor);
      }
      if (PhaseId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PhaseId);
      }
      if (Contribution != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Contribution);
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
      takenPhaseRewardList_.WriteTo(ref output, _repeated_takenPhaseRewardList_codec);
      if (Days != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Days);
      }
      takenContributionRewardList_.WriteTo(ref output, _repeated_takenContributionRewardList_codec);
      if (Progress != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Progress);
      }
      if (Factor != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Factor);
      }
      if (PhaseId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PhaseId);
      }
      if (Contribution != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Contribution);
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
      if (PhaseId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PhaseId);
      }
      size += takenPhaseRewardList_.CalculateSize(_repeated_takenPhaseRewardList_codec);
      size += takenContributionRewardList_.CalculateSize(_repeated_takenContributionRewardList_codec);
      if (Progress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
      }
      if (Contribution != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Contribution);
      }
      if (Factor != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Factor);
      }
      if (Days != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Days);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SeaLampActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.PhaseId != 0) {
        PhaseId = other.PhaseId;
      }
      takenPhaseRewardList_.Add(other.takenPhaseRewardList_);
      takenContributionRewardList_.Add(other.takenContributionRewardList_);
      if (other.Progress != 0) {
        Progress = other.Progress;
      }
      if (other.Contribution != 0) {
        Contribution = other.Contribution;
      }
      if (other.Factor != 0) {
        Factor = other.Factor;
      }
      if (other.Days != 0) {
        Days = other.Days;
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
          case 10:
          case 8: {
            takenPhaseRewardList_.AddEntriesFrom(input, _repeated_takenPhaseRewardList_codec);
            break;
          }
          case 32: {
            Days = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            takenContributionRewardList_.AddEntriesFrom(input, _repeated_takenContributionRewardList_codec);
            break;
          }
          case 64: {
            Progress = input.ReadUInt32();
            break;
          }
          case 104: {
            Factor = input.ReadUInt32();
            break;
          }
          case 112: {
            PhaseId = input.ReadUInt32();
            break;
          }
          case 120: {
            Contribution = input.ReadUInt32();
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
          case 10:
          case 8: {
            takenPhaseRewardList_.AddEntriesFrom(ref input, _repeated_takenPhaseRewardList_codec);
            break;
          }
          case 32: {
            Days = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            takenContributionRewardList_.AddEntriesFrom(ref input, _repeated_takenContributionRewardList_codec);
            break;
          }
          case 64: {
            Progress = input.ReadUInt32();
            break;
          }
          case 104: {
            Factor = input.ReadUInt32();
            break;
          }
          case 112: {
            PhaseId = input.ReadUInt32();
            break;
          }
          case 120: {
            Contribution = input.ReadUInt32();
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
