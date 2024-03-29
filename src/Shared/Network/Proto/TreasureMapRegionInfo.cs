// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TreasureMapRegionInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from TreasureMapRegionInfo.proto</summary>
  public static partial class TreasureMapRegionInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TreasureMapRegionInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TreasureMapRegionInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtUcmVhc3VyZU1hcFJlZ2lvbkluZm8ucHJvdG8aDFZlY3Rvci5wcm90byLs",
            "AQoVVHJlYXN1cmVNYXBSZWdpb25JbmZvEhIKCnN0YXJ0X3RpbWUYBiABKA0S",
            "GAoQY3VycmVudF9wcm9ncmVzcxgLIAEoDRIXCg9pc19kb25lX21wX3Nwb3QY",
            "AyABKAgSEAoIc2NlbmVfaWQYAiABKA0SEwoLZ29hbF9wb2ludHMYDCABKA0S",
            "FwoPaXNfZmluZF9tcF9zcG90GAQgASgIEhUKDXJlZ2lvbl9yYWRpdXMYASAB",
            "KA0SIgoRcmVnaW9uX2NlbnRlcl9wb3MYCSABKAsyBy5WZWN0b3ISEQoJcmVn",
            "aW9uX2lkGAUgASgNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.TreasureMapRegionInfo), global::Weedwacker.Shared.Network.Proto.TreasureMapRegionInfo.Parser, new[]{ "StartTime", "CurrentProgress", "IsDoneMpSpot", "SceneId", "GoalPoints", "IsFindMpSpot", "RegionRadius", "RegionCenterPos", "RegionId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TreasureMapRegionInfo : pb::IMessage<TreasureMapRegionInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TreasureMapRegionInfo> _parser = new pb::MessageParser<TreasureMapRegionInfo>(() => new TreasureMapRegionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TreasureMapRegionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.TreasureMapRegionInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureMapRegionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureMapRegionInfo(TreasureMapRegionInfo other) : this() {
      startTime_ = other.startTime_;
      currentProgress_ = other.currentProgress_;
      isDoneMpSpot_ = other.isDoneMpSpot_;
      sceneId_ = other.sceneId_;
      goalPoints_ = other.goalPoints_;
      isFindMpSpot_ = other.isFindMpSpot_;
      regionRadius_ = other.regionRadius_;
      regionCenterPos_ = other.regionCenterPos_ != null ? other.regionCenterPos_.Clone() : null;
      regionId_ = other.regionId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureMapRegionInfo Clone() {
      return new TreasureMapRegionInfo(this);
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 6;
    private uint startTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "current_progress" field.</summary>
    public const int CurrentProgressFieldNumber = 11;
    private uint currentProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurrentProgress {
      get { return currentProgress_; }
      set {
        currentProgress_ = value;
      }
    }

    /// <summary>Field number for the "is_done_mp_spot" field.</summary>
    public const int IsDoneMpSpotFieldNumber = 3;
    private bool isDoneMpSpot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsDoneMpSpot {
      get { return isDoneMpSpot_; }
      set {
        isDoneMpSpot_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 2;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "goal_points" field.</summary>
    public const int GoalPointsFieldNumber = 12;
    private uint goalPoints_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GoalPoints {
      get { return goalPoints_; }
      set {
        goalPoints_ = value;
      }
    }

    /// <summary>Field number for the "is_find_mp_spot" field.</summary>
    public const int IsFindMpSpotFieldNumber = 4;
    private bool isFindMpSpot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFindMpSpot {
      get { return isFindMpSpot_; }
      set {
        isFindMpSpot_ = value;
      }
    }

    /// <summary>Field number for the "region_radius" field.</summary>
    public const int RegionRadiusFieldNumber = 1;
    private uint regionRadius_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RegionRadius {
      get { return regionRadius_; }
      set {
        regionRadius_ = value;
      }
    }

    /// <summary>Field number for the "region_center_pos" field.</summary>
    public const int RegionCenterPosFieldNumber = 9;
    private global::Weedwacker.Shared.Network.Proto.Vector regionCenterPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector RegionCenterPos {
      get { return regionCenterPos_; }
      set {
        regionCenterPos_ = value;
      }
    }

    /// <summary>Field number for the "region_id" field.</summary>
    public const int RegionIdFieldNumber = 5;
    private uint regionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RegionId {
      get { return regionId_; }
      set {
        regionId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TreasureMapRegionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TreasureMapRegionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StartTime != other.StartTime) return false;
      if (CurrentProgress != other.CurrentProgress) return false;
      if (IsDoneMpSpot != other.IsDoneMpSpot) return false;
      if (SceneId != other.SceneId) return false;
      if (GoalPoints != other.GoalPoints) return false;
      if (IsFindMpSpot != other.IsFindMpSpot) return false;
      if (RegionRadius != other.RegionRadius) return false;
      if (!object.Equals(RegionCenterPos, other.RegionCenterPos)) return false;
      if (RegionId != other.RegionId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StartTime != 0) hash ^= StartTime.GetHashCode();
      if (CurrentProgress != 0) hash ^= CurrentProgress.GetHashCode();
      if (IsDoneMpSpot != false) hash ^= IsDoneMpSpot.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (GoalPoints != 0) hash ^= GoalPoints.GetHashCode();
      if (IsFindMpSpot != false) hash ^= IsFindMpSpot.GetHashCode();
      if (RegionRadius != 0) hash ^= RegionRadius.GetHashCode();
      if (regionCenterPos_ != null) hash ^= RegionCenterPos.GetHashCode();
      if (RegionId != 0) hash ^= RegionId.GetHashCode();
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
      if (RegionRadius != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(RegionRadius);
      }
      if (SceneId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SceneId);
      }
      if (IsDoneMpSpot != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsDoneMpSpot);
      }
      if (IsFindMpSpot != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsFindMpSpot);
      }
      if (RegionId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(RegionId);
      }
      if (StartTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(StartTime);
      }
      if (regionCenterPos_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RegionCenterPos);
      }
      if (CurrentProgress != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CurrentProgress);
      }
      if (GoalPoints != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(GoalPoints);
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
      if (RegionRadius != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(RegionRadius);
      }
      if (SceneId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SceneId);
      }
      if (IsDoneMpSpot != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsDoneMpSpot);
      }
      if (IsFindMpSpot != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsFindMpSpot);
      }
      if (RegionId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(RegionId);
      }
      if (StartTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(StartTime);
      }
      if (regionCenterPos_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RegionCenterPos);
      }
      if (CurrentProgress != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CurrentProgress);
      }
      if (GoalPoints != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(GoalPoints);
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
      if (StartTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartTime);
      }
      if (CurrentProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurrentProgress);
      }
      if (IsDoneMpSpot != false) {
        size += 1 + 1;
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (GoalPoints != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GoalPoints);
      }
      if (IsFindMpSpot != false) {
        size += 1 + 1;
      }
      if (RegionRadius != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RegionRadius);
      }
      if (regionCenterPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RegionCenterPos);
      }
      if (RegionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RegionId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TreasureMapRegionInfo other) {
      if (other == null) {
        return;
      }
      if (other.StartTime != 0) {
        StartTime = other.StartTime;
      }
      if (other.CurrentProgress != 0) {
        CurrentProgress = other.CurrentProgress;
      }
      if (other.IsDoneMpSpot != false) {
        IsDoneMpSpot = other.IsDoneMpSpot;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.GoalPoints != 0) {
        GoalPoints = other.GoalPoints;
      }
      if (other.IsFindMpSpot != false) {
        IsFindMpSpot = other.IsFindMpSpot;
      }
      if (other.RegionRadius != 0) {
        RegionRadius = other.RegionRadius;
      }
      if (other.regionCenterPos_ != null) {
        if (regionCenterPos_ == null) {
          RegionCenterPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        RegionCenterPos.MergeFrom(other.RegionCenterPos);
      }
      if (other.RegionId != 0) {
        RegionId = other.RegionId;
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
            RegionRadius = input.ReadUInt32();
            break;
          }
          case 16: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 24: {
            IsDoneMpSpot = input.ReadBool();
            break;
          }
          case 32: {
            IsFindMpSpot = input.ReadBool();
            break;
          }
          case 40: {
            RegionId = input.ReadUInt32();
            break;
          }
          case 48: {
            StartTime = input.ReadUInt32();
            break;
          }
          case 74: {
            if (regionCenterPos_ == null) {
              RegionCenterPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(RegionCenterPos);
            break;
          }
          case 88: {
            CurrentProgress = input.ReadUInt32();
            break;
          }
          case 96: {
            GoalPoints = input.ReadUInt32();
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
            RegionRadius = input.ReadUInt32();
            break;
          }
          case 16: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 24: {
            IsDoneMpSpot = input.ReadBool();
            break;
          }
          case 32: {
            IsFindMpSpot = input.ReadBool();
            break;
          }
          case 40: {
            RegionId = input.ReadUInt32();
            break;
          }
          case 48: {
            StartTime = input.ReadUInt32();
            break;
          }
          case 74: {
            if (regionCenterPos_ == null) {
              RegionCenterPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(RegionCenterPos);
            break;
          }
          case 88: {
            CurrentProgress = input.ReadUInt32();
            break;
          }
          case 96: {
            GoalPoints = input.ReadUInt32();
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
