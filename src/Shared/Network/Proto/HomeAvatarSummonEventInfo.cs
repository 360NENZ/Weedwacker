// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeAvatarSummonEventInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeAvatarSummonEventInfo.proto</summary>
  public static partial class HomeAvatarSummonEventInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeAvatarSummonEventInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeAvatarSummonEventInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Ib21lQXZhdGFyU3VtbW9uRXZlbnRJbmZvLnByb3RvIpEBChlIb21lQXZh",
            "dGFyU3VtbW9uRXZlbnRJbmZvEhEKCWF2YXRhcl9pZBgDIAEoDRIMCgRndWlk",
            "GAggASgNEhAKCGV2ZW50X2lkGAkgASgNEg8KB3N1aXRfaWQYDCABKA0SFwoP",
            "ZXZlbnRfb3Zlcl90aW1lGAIgASgNEhcKD3JhbmRvbV9wb3NpdGlvbhgKIAEo",
            "DUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeAvatarSummonEventInfo), global::Weedwacker.Shared.Network.Proto.HomeAvatarSummonEventInfo.Parser, new[]{ "AvatarId", "Guid", "EventId", "SuitId", "EventOverTime", "RandomPosition" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeAvatarSummonEventInfo : pb::IMessage<HomeAvatarSummonEventInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeAvatarSummonEventInfo> _parser = new pb::MessageParser<HomeAvatarSummonEventInfo>(() => new HomeAvatarSummonEventInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeAvatarSummonEventInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeAvatarSummonEventInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeAvatarSummonEventInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeAvatarSummonEventInfo(HomeAvatarSummonEventInfo other) : this() {
      avatarId_ = other.avatarId_;
      guid_ = other.guid_;
      eventId_ = other.eventId_;
      suitId_ = other.suitId_;
      eventOverTime_ = other.eventOverTime_;
      randomPosition_ = other.randomPosition_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeAvatarSummonEventInfo Clone() {
      return new HomeAvatarSummonEventInfo(this);
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 3;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 8;
    private uint guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 9;
    private uint eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
      }
    }

    /// <summary>Field number for the "suit_id" field.</summary>
    public const int SuitIdFieldNumber = 12;
    private uint suitId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SuitId {
      get { return suitId_; }
      set {
        suitId_ = value;
      }
    }

    /// <summary>Field number for the "event_over_time" field.</summary>
    public const int EventOverTimeFieldNumber = 2;
    private uint eventOverTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventOverTime {
      get { return eventOverTime_; }
      set {
        eventOverTime_ = value;
      }
    }

    /// <summary>Field number for the "random_position" field.</summary>
    public const int RandomPositionFieldNumber = 10;
    private uint randomPosition_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RandomPosition {
      get { return randomPosition_; }
      set {
        randomPosition_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeAvatarSummonEventInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeAvatarSummonEventInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarId != other.AvatarId) return false;
      if (Guid != other.Guid) return false;
      if (EventId != other.EventId) return false;
      if (SuitId != other.SuitId) return false;
      if (EventOverTime != other.EventOverTime) return false;
      if (RandomPosition != other.RandomPosition) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      if (Guid != 0) hash ^= Guid.GetHashCode();
      if (EventId != 0) hash ^= EventId.GetHashCode();
      if (SuitId != 0) hash ^= SuitId.GetHashCode();
      if (EventOverTime != 0) hash ^= EventOverTime.GetHashCode();
      if (RandomPosition != 0) hash ^= RandomPosition.GetHashCode();
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
      if (EventOverTime != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EventOverTime);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(AvatarId);
      }
      if (Guid != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Guid);
      }
      if (EventId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EventId);
      }
      if (RandomPosition != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RandomPosition);
      }
      if (SuitId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SuitId);
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
      if (EventOverTime != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EventOverTime);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(AvatarId);
      }
      if (Guid != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Guid);
      }
      if (EventId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EventId);
      }
      if (RandomPosition != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RandomPosition);
      }
      if (SuitId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SuitId);
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
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      if (Guid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Guid);
      }
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventId);
      }
      if (SuitId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SuitId);
      }
      if (EventOverTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventOverTime);
      }
      if (RandomPosition != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RandomPosition);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeAvatarSummonEventInfo other) {
      if (other == null) {
        return;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      if (other.Guid != 0) {
        Guid = other.Guid;
      }
      if (other.EventId != 0) {
        EventId = other.EventId;
      }
      if (other.SuitId != 0) {
        SuitId = other.SuitId;
      }
      if (other.EventOverTime != 0) {
        EventOverTime = other.EventOverTime;
      }
      if (other.RandomPosition != 0) {
        RandomPosition = other.RandomPosition;
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
          case 16: {
            EventOverTime = input.ReadUInt32();
            break;
          }
          case 24: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 64: {
            Guid = input.ReadUInt32();
            break;
          }
          case 72: {
            EventId = input.ReadUInt32();
            break;
          }
          case 80: {
            RandomPosition = input.ReadUInt32();
            break;
          }
          case 96: {
            SuitId = input.ReadUInt32();
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
          case 16: {
            EventOverTime = input.ReadUInt32();
            break;
          }
          case 24: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 64: {
            Guid = input.ReadUInt32();
            break;
          }
          case 72: {
            EventId = input.ReadUInt32();
            break;
          }
          case 80: {
            RandomPosition = input.ReadUInt32();
            break;
          }
          case 96: {
            SuitId = input.ReadUInt32();
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
