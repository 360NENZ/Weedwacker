// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UpgradeRoguelikeShikigamiReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from UpgradeRoguelikeShikigamiReq.proto</summary>
  public static partial class UpgradeRoguelikeShikigamiReqReflection {

    #region Descriptor
    /// <summary>File descriptor for UpgradeRoguelikeShikigamiReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpgradeRoguelikeShikigamiReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJVcGdyYWRlUm9ndWVsaWtlU2hpa2lnYW1pUmVxLnByb3RvIlEKHFVwZ3Jh",
            "ZGVSb2d1ZWxpa2VTaGlraWdhbWlSZXESFQoNdXBncmFkZV9sZXZlbBgGIAEo",
            "DRIaChJzaGlraWdhbWlfZ3JvdXBfaWQYDyABKA1CIqoCH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.UpgradeRoguelikeShikigamiReq), global::Weedwacker.Shared.Network.Proto.UpgradeRoguelikeShikigamiReq.Parser, new[]{ "UpgradeLevel", "ShikigamiGroupId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8151
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class UpgradeRoguelikeShikigamiReq : pb::IMessage<UpgradeRoguelikeShikigamiReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UpgradeRoguelikeShikigamiReq> _parser = new pb::MessageParser<UpgradeRoguelikeShikigamiReq>(() => new UpgradeRoguelikeShikigamiReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UpgradeRoguelikeShikigamiReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.UpgradeRoguelikeShikigamiReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpgradeRoguelikeShikigamiReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpgradeRoguelikeShikigamiReq(UpgradeRoguelikeShikigamiReq other) : this() {
      upgradeLevel_ = other.upgradeLevel_;
      shikigamiGroupId_ = other.shikigamiGroupId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpgradeRoguelikeShikigamiReq Clone() {
      return new UpgradeRoguelikeShikigamiReq(this);
    }

    /// <summary>Field number for the "upgrade_level" field.</summary>
    public const int UpgradeLevelFieldNumber = 6;
    private uint upgradeLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UpgradeLevel {
      get { return upgradeLevel_; }
      set {
        upgradeLevel_ = value;
      }
    }

    /// <summary>Field number for the "shikigami_group_id" field.</summary>
    public const int ShikigamiGroupIdFieldNumber = 15;
    private uint shikigamiGroupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShikigamiGroupId {
      get { return shikigamiGroupId_; }
      set {
        shikigamiGroupId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UpgradeRoguelikeShikigamiReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UpgradeRoguelikeShikigamiReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UpgradeLevel != other.UpgradeLevel) return false;
      if (ShikigamiGroupId != other.ShikigamiGroupId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (UpgradeLevel != 0) hash ^= UpgradeLevel.GetHashCode();
      if (ShikigamiGroupId != 0) hash ^= ShikigamiGroupId.GetHashCode();
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
      if (UpgradeLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(UpgradeLevel);
      }
      if (ShikigamiGroupId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ShikigamiGroupId);
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
      if (UpgradeLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(UpgradeLevel);
      }
      if (ShikigamiGroupId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ShikigamiGroupId);
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
      if (UpgradeLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UpgradeLevel);
      }
      if (ShikigamiGroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShikigamiGroupId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UpgradeRoguelikeShikigamiReq other) {
      if (other == null) {
        return;
      }
      if (other.UpgradeLevel != 0) {
        UpgradeLevel = other.UpgradeLevel;
      }
      if (other.ShikigamiGroupId != 0) {
        ShikigamiGroupId = other.ShikigamiGroupId;
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
          case 48: {
            UpgradeLevel = input.ReadUInt32();
            break;
          }
          case 120: {
            ShikigamiGroupId = input.ReadUInt32();
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
          case 48: {
            UpgradeLevel = input.ReadUInt32();
            break;
          }
          case 120: {
            ShikigamiGroupId = input.ReadUInt32();
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
