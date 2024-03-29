// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarSkillChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AvatarSkillChangeNotify.proto</summary>
  public static partial class AvatarSkillChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for AvatarSkillChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarSkillChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1BdmF0YXJTa2lsbENoYW5nZU5vdGlmeS5wcm90byKYAQoXQXZhdGFyU2tp",
            "bGxDaGFuZ2VOb3RpZnkSEQoJY3VyX2xldmVsGAsgASgNEhMKC2F2YXRhcl9n",
            "dWlkGAIgASgEEhEKCWVudGl0eV9pZBgHIAEoDRIWCg5za2lsbF9kZXBvdF9p",
            "ZBgNIAEoDRIRCglvbGRfbGV2ZWwYASABKA0SFwoPYXZhdGFyX3NraWxsX2lk",
            "GAYgASgNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AvatarSkillChangeNotify), global::Weedwacker.Shared.Network.Proto.AvatarSkillChangeNotify.Parser, new[]{ "CurLevel", "AvatarGuid", "EntityId", "SkillDepotId", "OldLevel", "AvatarSkillId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1097
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class AvatarSkillChangeNotify : pb::IMessage<AvatarSkillChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AvatarSkillChangeNotify> _parser = new pb::MessageParser<AvatarSkillChangeNotify>(() => new AvatarSkillChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AvatarSkillChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AvatarSkillChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarSkillChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarSkillChangeNotify(AvatarSkillChangeNotify other) : this() {
      curLevel_ = other.curLevel_;
      avatarGuid_ = other.avatarGuid_;
      entityId_ = other.entityId_;
      skillDepotId_ = other.skillDepotId_;
      oldLevel_ = other.oldLevel_;
      avatarSkillId_ = other.avatarSkillId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarSkillChangeNotify Clone() {
      return new AvatarSkillChangeNotify(this);
    }

    /// <summary>Field number for the "cur_level" field.</summary>
    public const int CurLevelFieldNumber = 11;
    private uint curLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurLevel {
      get { return curLevel_; }
      set {
        curLevel_ = value;
      }
    }

    /// <summary>Field number for the "avatar_guid" field.</summary>
    public const int AvatarGuidFieldNumber = 2;
    private ulong avatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AvatarGuid {
      get { return avatarGuid_; }
      set {
        avatarGuid_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 7;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "skill_depot_id" field.</summary>
    public const int SkillDepotIdFieldNumber = 13;
    private uint skillDepotId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillDepotId {
      get { return skillDepotId_; }
      set {
        skillDepotId_ = value;
      }
    }

    /// <summary>Field number for the "old_level" field.</summary>
    public const int OldLevelFieldNumber = 1;
    private uint oldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OldLevel {
      get { return oldLevel_; }
      set {
        oldLevel_ = value;
      }
    }

    /// <summary>Field number for the "avatar_skill_id" field.</summary>
    public const int AvatarSkillIdFieldNumber = 6;
    private uint avatarSkillId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarSkillId {
      get { return avatarSkillId_; }
      set {
        avatarSkillId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AvatarSkillChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AvatarSkillChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurLevel != other.CurLevel) return false;
      if (AvatarGuid != other.AvatarGuid) return false;
      if (EntityId != other.EntityId) return false;
      if (SkillDepotId != other.SkillDepotId) return false;
      if (OldLevel != other.OldLevel) return false;
      if (AvatarSkillId != other.AvatarSkillId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurLevel != 0) hash ^= CurLevel.GetHashCode();
      if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (SkillDepotId != 0) hash ^= SkillDepotId.GetHashCode();
      if (OldLevel != 0) hash ^= OldLevel.GetHashCode();
      if (AvatarSkillId != 0) hash ^= AvatarSkillId.GetHashCode();
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
      if (OldLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(OldLevel);
      }
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(AvatarGuid);
      }
      if (AvatarSkillId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(AvatarSkillId);
      }
      if (EntityId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EntityId);
      }
      if (CurLevel != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CurLevel);
      }
      if (SkillDepotId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SkillDepotId);
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
      if (OldLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(OldLevel);
      }
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(AvatarGuid);
      }
      if (AvatarSkillId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(AvatarSkillId);
      }
      if (EntityId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EntityId);
      }
      if (CurLevel != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CurLevel);
      }
      if (SkillDepotId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SkillDepotId);
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
      if (CurLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurLevel);
      }
      if (AvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (SkillDepotId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillDepotId);
      }
      if (OldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OldLevel);
      }
      if (AvatarSkillId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarSkillId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AvatarSkillChangeNotify other) {
      if (other == null) {
        return;
      }
      if (other.CurLevel != 0) {
        CurLevel = other.CurLevel;
      }
      if (other.AvatarGuid != 0UL) {
        AvatarGuid = other.AvatarGuid;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.SkillDepotId != 0) {
        SkillDepotId = other.SkillDepotId;
      }
      if (other.OldLevel != 0) {
        OldLevel = other.OldLevel;
      }
      if (other.AvatarSkillId != 0) {
        AvatarSkillId = other.AvatarSkillId;
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
            OldLevel = input.ReadUInt32();
            break;
          }
          case 16: {
            AvatarGuid = input.ReadUInt64();
            break;
          }
          case 48: {
            AvatarSkillId = input.ReadUInt32();
            break;
          }
          case 56: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 88: {
            CurLevel = input.ReadUInt32();
            break;
          }
          case 104: {
            SkillDepotId = input.ReadUInt32();
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
            OldLevel = input.ReadUInt32();
            break;
          }
          case 16: {
            AvatarGuid = input.ReadUInt64();
            break;
          }
          case 48: {
            AvatarSkillId = input.ReadUInt32();
            break;
          }
          case 56: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 88: {
            CurLevel = input.ReadUInt32();
            break;
          }
          case 104: {
            SkillDepotId = input.ReadUInt32();
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
