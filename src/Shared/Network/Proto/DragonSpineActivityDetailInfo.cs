// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DragonSpineActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from DragonSpineActivityDetailInfo.proto</summary>
  public static partial class DragonSpineActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for DragonSpineActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DragonSpineActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNEcmFnb25TcGluZUFjdGl2aXR5RGV0YWlsSW5mby5wcm90bxocRHJhZ29u",
            "U3BpbmVDaGFwdGVySW5mby5wcm90byL1AQodRHJhZ29uU3BpbmVBY3Rpdml0",
            "eURldGFpbEluZm8SGQoRaXNfY29udGVudF9jbG9zZWQYCiABKAgSMgoRY2hh",
            "cHRlcl9pbmZvX2xpc3QYBCADKAsyFy5EcmFnb25TcGluZUNoYXB0ZXJJbmZv",
            "EhwKFHdlYXBvbl9lbmhhbmNlX2xldmVsGAIgASgNEhsKE2NvbnRlbnRfZmlu",
            "aXNoX3RpbWUYDyABKA0SGgoSc2hpbW1lcmluZ19lc3NlbmNlGA0gASgNEhQK",
            "DHdhcm1fZXNzZW5jZRgLIAEoDRIYChB3b25kcm91c19lc3NlbmNlGAcgASgN",
            "QiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.DragonSpineChapterInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.DragonSpineActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.DragonSpineActivityDetailInfo.Parser, new[]{ "IsContentClosed", "ChapterInfoList", "WeaponEnhanceLevel", "ContentFinishTime", "ShimmeringEssence", "WarmEssence", "WondrousEssence" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DragonSpineActivityDetailInfo : pb::IMessage<DragonSpineActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DragonSpineActivityDetailInfo> _parser = new pb::MessageParser<DragonSpineActivityDetailInfo>(() => new DragonSpineActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DragonSpineActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.DragonSpineActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DragonSpineActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DragonSpineActivityDetailInfo(DragonSpineActivityDetailInfo other) : this() {
      isContentClosed_ = other.isContentClosed_;
      chapterInfoList_ = other.chapterInfoList_.Clone();
      weaponEnhanceLevel_ = other.weaponEnhanceLevel_;
      contentFinishTime_ = other.contentFinishTime_;
      shimmeringEssence_ = other.shimmeringEssence_;
      warmEssence_ = other.warmEssence_;
      wondrousEssence_ = other.wondrousEssence_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DragonSpineActivityDetailInfo Clone() {
      return new DragonSpineActivityDetailInfo(this);
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 10;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    /// <summary>Field number for the "chapter_info_list" field.</summary>
    public const int ChapterInfoListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.DragonSpineChapterInfo> _repeated_chapterInfoList_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Shared.Network.Proto.DragonSpineChapterInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.DragonSpineChapterInfo> chapterInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.DragonSpineChapterInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.DragonSpineChapterInfo> ChapterInfoList {
      get { return chapterInfoList_; }
    }

    /// <summary>Field number for the "weapon_enhance_level" field.</summary>
    public const int WeaponEnhanceLevelFieldNumber = 2;
    private uint weaponEnhanceLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WeaponEnhanceLevel {
      get { return weaponEnhanceLevel_; }
      set {
        weaponEnhanceLevel_ = value;
      }
    }

    /// <summary>Field number for the "content_finish_time" field.</summary>
    public const int ContentFinishTimeFieldNumber = 15;
    private uint contentFinishTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ContentFinishTime {
      get { return contentFinishTime_; }
      set {
        contentFinishTime_ = value;
      }
    }

    /// <summary>Field number for the "shimmering_essence" field.</summary>
    public const int ShimmeringEssenceFieldNumber = 13;
    private uint shimmeringEssence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShimmeringEssence {
      get { return shimmeringEssence_; }
      set {
        shimmeringEssence_ = value;
      }
    }

    /// <summary>Field number for the "warm_essence" field.</summary>
    public const int WarmEssenceFieldNumber = 11;
    private uint warmEssence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WarmEssence {
      get { return warmEssence_; }
      set {
        warmEssence_ = value;
      }
    }

    /// <summary>Field number for the "wondrous_essence" field.</summary>
    public const int WondrousEssenceFieldNumber = 7;
    private uint wondrousEssence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WondrousEssence {
      get { return wondrousEssence_; }
      set {
        wondrousEssence_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DragonSpineActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DragonSpineActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsContentClosed != other.IsContentClosed) return false;
      if(!chapterInfoList_.Equals(other.chapterInfoList_)) return false;
      if (WeaponEnhanceLevel != other.WeaponEnhanceLevel) return false;
      if (ContentFinishTime != other.ContentFinishTime) return false;
      if (ShimmeringEssence != other.ShimmeringEssence) return false;
      if (WarmEssence != other.WarmEssence) return false;
      if (WondrousEssence != other.WondrousEssence) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
      hash ^= chapterInfoList_.GetHashCode();
      if (WeaponEnhanceLevel != 0) hash ^= WeaponEnhanceLevel.GetHashCode();
      if (ContentFinishTime != 0) hash ^= ContentFinishTime.GetHashCode();
      if (ShimmeringEssence != 0) hash ^= ShimmeringEssence.GetHashCode();
      if (WarmEssence != 0) hash ^= WarmEssence.GetHashCode();
      if (WondrousEssence != 0) hash ^= WondrousEssence.GetHashCode();
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
      if (WeaponEnhanceLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(WeaponEnhanceLevel);
      }
      chapterInfoList_.WriteTo(output, _repeated_chapterInfoList_codec);
      if (WondrousEssence != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(WondrousEssence);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsContentClosed);
      }
      if (WarmEssence != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WarmEssence);
      }
      if (ShimmeringEssence != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ShimmeringEssence);
      }
      if (ContentFinishTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ContentFinishTime);
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
      if (WeaponEnhanceLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(WeaponEnhanceLevel);
      }
      chapterInfoList_.WriteTo(ref output, _repeated_chapterInfoList_codec);
      if (WondrousEssence != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(WondrousEssence);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsContentClosed);
      }
      if (WarmEssence != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WarmEssence);
      }
      if (ShimmeringEssence != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ShimmeringEssence);
      }
      if (ContentFinishTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ContentFinishTime);
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
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      size += chapterInfoList_.CalculateSize(_repeated_chapterInfoList_codec);
      if (WeaponEnhanceLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WeaponEnhanceLevel);
      }
      if (ContentFinishTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ContentFinishTime);
      }
      if (ShimmeringEssence != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShimmeringEssence);
      }
      if (WarmEssence != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WarmEssence);
      }
      if (WondrousEssence != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WondrousEssence);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DragonSpineActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
      }
      chapterInfoList_.Add(other.chapterInfoList_);
      if (other.WeaponEnhanceLevel != 0) {
        WeaponEnhanceLevel = other.WeaponEnhanceLevel;
      }
      if (other.ContentFinishTime != 0) {
        ContentFinishTime = other.ContentFinishTime;
      }
      if (other.ShimmeringEssence != 0) {
        ShimmeringEssence = other.ShimmeringEssence;
      }
      if (other.WarmEssence != 0) {
        WarmEssence = other.WarmEssence;
      }
      if (other.WondrousEssence != 0) {
        WondrousEssence = other.WondrousEssence;
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
            WeaponEnhanceLevel = input.ReadUInt32();
            break;
          }
          case 34: {
            chapterInfoList_.AddEntriesFrom(input, _repeated_chapterInfoList_codec);
            break;
          }
          case 56: {
            WondrousEssence = input.ReadUInt32();
            break;
          }
          case 80: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 88: {
            WarmEssence = input.ReadUInt32();
            break;
          }
          case 104: {
            ShimmeringEssence = input.ReadUInt32();
            break;
          }
          case 120: {
            ContentFinishTime = input.ReadUInt32();
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
            WeaponEnhanceLevel = input.ReadUInt32();
            break;
          }
          case 34: {
            chapterInfoList_.AddEntriesFrom(ref input, _repeated_chapterInfoList_codec);
            break;
          }
          case 56: {
            WondrousEssence = input.ReadUInt32();
            break;
          }
          case 80: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 88: {
            WarmEssence = input.ReadUInt32();
            break;
          }
          case 104: {
            ShimmeringEssence = input.ReadUInt32();
            break;
          }
          case 120: {
            ContentFinishTime = input.ReadUInt32();
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
