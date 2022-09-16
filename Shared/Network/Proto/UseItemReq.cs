// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UseItemReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from UseItemReq.proto</summary>
  public static partial class UseItemReqReflection {

    #region Descriptor
    /// <summary>File descriptor for UseItemReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBVc2VJdGVtUmVxLnByb3RvInQKClVzZUl0ZW1SZXESDQoFY291bnQYDSAB",
            "KA0SEwoLdGFyZ2V0X2d1aWQYDiABKAQSDAoEZ3VpZBgKIAEoBBIgChhpc19l",
            "bnRlcl9tcF9kdW5nZW9uX3RlYW0YDyABKAgSEgoKb3B0aW9uX2lkeBgHIAEo",
            "DUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.UseItemReq), global::Weedwacker.Shared.Network.Proto.UseItemReq.Parser, new[]{ "Count", "TargetGuid", "Guid", "IsEnterMpDungeonTeam", "OptionIdx" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 690
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class UseItemReq : pb::IMessage<UseItemReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UseItemReq> _parser = new pb::MessageParser<UseItemReq>(() => new UseItemReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UseItemReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.UseItemReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemReq(UseItemReq other) : this() {
      count_ = other.count_;
      targetGuid_ = other.targetGuid_;
      guid_ = other.guid_;
      isEnterMpDungeonTeam_ = other.isEnterMpDungeonTeam_;
      optionIdx_ = other.optionIdx_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemReq Clone() {
      return new UseItemReq(this);
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 13;
    private uint count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "target_guid" field.</summary>
    public const int TargetGuidFieldNumber = 14;
    private ulong targetGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TargetGuid {
      get { return targetGuid_; }
      set {
        targetGuid_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 10;
    private ulong guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "is_enter_mp_dungeon_team" field.</summary>
    public const int IsEnterMpDungeonTeamFieldNumber = 15;
    private bool isEnterMpDungeonTeam_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsEnterMpDungeonTeam {
      get { return isEnterMpDungeonTeam_; }
      set {
        isEnterMpDungeonTeam_ = value;
      }
    }

    /// <summary>Field number for the "option_idx" field.</summary>
    public const int OptionIdxFieldNumber = 7;
    private uint optionIdx_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OptionIdx {
      get { return optionIdx_; }
      set {
        optionIdx_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UseItemReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UseItemReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Count != other.Count) return false;
      if (TargetGuid != other.TargetGuid) return false;
      if (Guid != other.Guid) return false;
      if (IsEnterMpDungeonTeam != other.IsEnterMpDungeonTeam) return false;
      if (OptionIdx != other.OptionIdx) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Count != 0) hash ^= Count.GetHashCode();
      if (TargetGuid != 0UL) hash ^= TargetGuid.GetHashCode();
      if (Guid != 0UL) hash ^= Guid.GetHashCode();
      if (IsEnterMpDungeonTeam != false) hash ^= IsEnterMpDungeonTeam.GetHashCode();
      if (OptionIdx != 0) hash ^= OptionIdx.GetHashCode();
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
      if (OptionIdx != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(OptionIdx);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(Guid);
      }
      if (Count != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Count);
      }
      if (TargetGuid != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(TargetGuid);
      }
      if (IsEnterMpDungeonTeam != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsEnterMpDungeonTeam);
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
      if (OptionIdx != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(OptionIdx);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(Guid);
      }
      if (Count != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Count);
      }
      if (TargetGuid != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(TargetGuid);
      }
      if (IsEnterMpDungeonTeam != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsEnterMpDungeonTeam);
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
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Count);
      }
      if (TargetGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TargetGuid);
      }
      if (Guid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Guid);
      }
      if (IsEnterMpDungeonTeam != false) {
        size += 1 + 1;
      }
      if (OptionIdx != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OptionIdx);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UseItemReq other) {
      if (other == null) {
        return;
      }
      if (other.Count != 0) {
        Count = other.Count;
      }
      if (other.TargetGuid != 0UL) {
        TargetGuid = other.TargetGuid;
      }
      if (other.Guid != 0UL) {
        Guid = other.Guid;
      }
      if (other.IsEnterMpDungeonTeam != false) {
        IsEnterMpDungeonTeam = other.IsEnterMpDungeonTeam;
      }
      if (other.OptionIdx != 0) {
        OptionIdx = other.OptionIdx;
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
          case 56: {
            OptionIdx = input.ReadUInt32();
            break;
          }
          case 80: {
            Guid = input.ReadUInt64();
            break;
          }
          case 104: {
            Count = input.ReadUInt32();
            break;
          }
          case 112: {
            TargetGuid = input.ReadUInt64();
            break;
          }
          case 120: {
            IsEnterMpDungeonTeam = input.ReadBool();
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
            OptionIdx = input.ReadUInt32();
            break;
          }
          case 80: {
            Guid = input.ReadUInt64();
            break;
          }
          case 104: {
            Count = input.ReadUInt32();
            break;
          }
          case 112: {
            TargetGuid = input.ReadUInt64();
            break;
          }
          case 120: {
            IsEnterMpDungeonTeam = input.ReadBool();
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