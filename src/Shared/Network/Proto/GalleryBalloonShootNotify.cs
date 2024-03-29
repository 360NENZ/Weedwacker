// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GalleryBalloonShootNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GalleryBalloonShootNotify.proto</summary>
  public static partial class GalleryBalloonShootNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GalleryBalloonShootNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GalleryBalloonShootNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9HYWxsZXJ5QmFsbG9vblNob290Tm90aWZ5LnByb3RvIpsBChlHYWxsZXJ5",
            "QmFsbG9vblNob290Tm90aWZ5EhkKEXRyaWdnZXJfZW50aXR5X2lkGAwgASgN",
            "EhIKCmdhbGxlcnlfaWQYBSABKA0SDQoFY29tYm8YDiABKA0SGgoSY29tYm9f",
            "ZGlzYWJsZV90aW1lGAYgASgEEhEKCWFkZF9zY29yZRgLIAEoBRIRCgljdXJf",
            "c2NvcmUYDSABKA1CIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GalleryBalloonShootNotify), global::Weedwacker.Shared.Network.Proto.GalleryBalloonShootNotify.Parser, new[]{ "TriggerEntityId", "GalleryId", "Combo", "ComboDisableTime", "AddScore", "CurScore" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 5598
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class GalleryBalloonShootNotify : pb::IMessage<GalleryBalloonShootNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GalleryBalloonShootNotify> _parser = new pb::MessageParser<GalleryBalloonShootNotify>(() => new GalleryBalloonShootNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GalleryBalloonShootNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GalleryBalloonShootNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryBalloonShootNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryBalloonShootNotify(GalleryBalloonShootNotify other) : this() {
      triggerEntityId_ = other.triggerEntityId_;
      galleryId_ = other.galleryId_;
      combo_ = other.combo_;
      comboDisableTime_ = other.comboDisableTime_;
      addScore_ = other.addScore_;
      curScore_ = other.curScore_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryBalloonShootNotify Clone() {
      return new GalleryBalloonShootNotify(this);
    }

    /// <summary>Field number for the "trigger_entity_id" field.</summary>
    public const int TriggerEntityIdFieldNumber = 12;
    private uint triggerEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TriggerEntityId {
      get { return triggerEntityId_; }
      set {
        triggerEntityId_ = value;
      }
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 5;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    /// <summary>Field number for the "combo" field.</summary>
    public const int ComboFieldNumber = 14;
    private uint combo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Combo {
      get { return combo_; }
      set {
        combo_ = value;
      }
    }

    /// <summary>Field number for the "combo_disable_time" field.</summary>
    public const int ComboDisableTimeFieldNumber = 6;
    private ulong comboDisableTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ComboDisableTime {
      get { return comboDisableTime_; }
      set {
        comboDisableTime_ = value;
      }
    }

    /// <summary>Field number for the "add_score" field.</summary>
    public const int AddScoreFieldNumber = 11;
    private int addScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int AddScore {
      get { return addScore_; }
      set {
        addScore_ = value;
      }
    }

    /// <summary>Field number for the "cur_score" field.</summary>
    public const int CurScoreFieldNumber = 13;
    private uint curScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurScore {
      get { return curScore_; }
      set {
        curScore_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GalleryBalloonShootNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GalleryBalloonShootNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TriggerEntityId != other.TriggerEntityId) return false;
      if (GalleryId != other.GalleryId) return false;
      if (Combo != other.Combo) return false;
      if (ComboDisableTime != other.ComboDisableTime) return false;
      if (AddScore != other.AddScore) return false;
      if (CurScore != other.CurScore) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TriggerEntityId != 0) hash ^= TriggerEntityId.GetHashCode();
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      if (Combo != 0) hash ^= Combo.GetHashCode();
      if (ComboDisableTime != 0UL) hash ^= ComboDisableTime.GetHashCode();
      if (AddScore != 0) hash ^= AddScore.GetHashCode();
      if (CurScore != 0) hash ^= CurScore.GetHashCode();
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
      if (GalleryId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GalleryId);
      }
      if (ComboDisableTime != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(ComboDisableTime);
      }
      if (AddScore != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(AddScore);
      }
      if (TriggerEntityId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(TriggerEntityId);
      }
      if (CurScore != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CurScore);
      }
      if (Combo != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Combo);
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
      if (GalleryId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GalleryId);
      }
      if (ComboDisableTime != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(ComboDisableTime);
      }
      if (AddScore != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(AddScore);
      }
      if (TriggerEntityId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(TriggerEntityId);
      }
      if (CurScore != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CurScore);
      }
      if (Combo != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Combo);
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
      if (TriggerEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TriggerEntityId);
      }
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (Combo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Combo);
      }
      if (ComboDisableTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ComboDisableTime);
      }
      if (AddScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AddScore);
      }
      if (CurScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurScore);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GalleryBalloonShootNotify other) {
      if (other == null) {
        return;
      }
      if (other.TriggerEntityId != 0) {
        TriggerEntityId = other.TriggerEntityId;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
      }
      if (other.Combo != 0) {
        Combo = other.Combo;
      }
      if (other.ComboDisableTime != 0UL) {
        ComboDisableTime = other.ComboDisableTime;
      }
      if (other.AddScore != 0) {
        AddScore = other.AddScore;
      }
      if (other.CurScore != 0) {
        CurScore = other.CurScore;
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
          case 40: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 48: {
            ComboDisableTime = input.ReadUInt64();
            break;
          }
          case 88: {
            AddScore = input.ReadInt32();
            break;
          }
          case 96: {
            TriggerEntityId = input.ReadUInt32();
            break;
          }
          case 104: {
            CurScore = input.ReadUInt32();
            break;
          }
          case 112: {
            Combo = input.ReadUInt32();
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
          case 40: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 48: {
            ComboDisableTime = input.ReadUInt64();
            break;
          }
          case 88: {
            AddScore = input.ReadInt32();
            break;
          }
          case 96: {
            TriggerEntityId = input.ReadUInt32();
            break;
          }
          case 104: {
            CurScore = input.ReadUInt32();
            break;
          }
          case 112: {
            Combo = input.ReadUInt32();
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
