// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EntityConfigHashNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from EntityConfigHashNotify.proto</summary>
  public static partial class EntityConfigHashNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EntityConfigHashNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EntityConfigHashNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxFbnRpdHlDb25maWdIYXNoTm90aWZ5LnByb3RvGhtFbnRpdHlDb25maWdI",
            "YXNoRW50cnkucHJvdG8isgEKFkVudGl0eUNvbmZpZ0hhc2hOb3RpZnkSMgoS",
            "YWJpbGl0eV9lbnRyeV9saXN0GAMgAygLMhYuRW50aXR5Q29uZmlnSGFzaEVu",
            "dHJ5EjEKEWF2YXRhcl9lbnRyeV9saXN0GA8gAygLMhYuRW50aXR5Q29uZmln",
            "SGFzaEVudHJ5EjEKEWNvbWJhdF9lbnRyeV9saXN0GAggAygLMhYuRW50aXR5",
            "Q29uZmlnSGFzaEVudHJ5QhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.EntityConfigHashEntryReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.EntityConfigHashNotify), global::Weedwacker.Server.Proto.EntityConfigHashNotify.Parser, new[]{ "AbilityEntryList", "AvatarEntryList", "CombatEntryList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 3189
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class EntityConfigHashNotify : pb::IMessage<EntityConfigHashNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EntityConfigHashNotify> _parser = new pb::MessageParser<EntityConfigHashNotify>(() => new EntityConfigHashNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EntityConfigHashNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.EntityConfigHashNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityConfigHashNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityConfigHashNotify(EntityConfigHashNotify other) : this() {
      abilityEntryList_ = other.abilityEntryList_.Clone();
      avatarEntryList_ = other.avatarEntryList_.Clone();
      combatEntryList_ = other.combatEntryList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityConfigHashNotify Clone() {
      return new EntityConfigHashNotify(this);
    }

    /// <summary>Field number for the "ability_entry_list" field.</summary>
    public const int AbilityEntryListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.EntityConfigHashEntry> _repeated_abilityEntryList_codec
        = pb::FieldCodec.ForMessage(26, global::Weedwacker.Server.Proto.EntityConfigHashEntry.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.EntityConfigHashEntry> abilityEntryList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.EntityConfigHashEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.EntityConfigHashEntry> AbilityEntryList {
      get { return abilityEntryList_; }
    }

    /// <summary>Field number for the "avatar_entry_list" field.</summary>
    public const int AvatarEntryListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.EntityConfigHashEntry> _repeated_avatarEntryList_codec
        = pb::FieldCodec.ForMessage(122, global::Weedwacker.Server.Proto.EntityConfigHashEntry.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.EntityConfigHashEntry> avatarEntryList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.EntityConfigHashEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.EntityConfigHashEntry> AvatarEntryList {
      get { return avatarEntryList_; }
    }

    /// <summary>Field number for the "combat_entry_list" field.</summary>
    public const int CombatEntryListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.EntityConfigHashEntry> _repeated_combatEntryList_codec
        = pb::FieldCodec.ForMessage(66, global::Weedwacker.Server.Proto.EntityConfigHashEntry.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.EntityConfigHashEntry> combatEntryList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.EntityConfigHashEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.EntityConfigHashEntry> CombatEntryList {
      get { return combatEntryList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EntityConfigHashNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EntityConfigHashNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!abilityEntryList_.Equals(other.abilityEntryList_)) return false;
      if(!avatarEntryList_.Equals(other.avatarEntryList_)) return false;
      if(!combatEntryList_.Equals(other.combatEntryList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= abilityEntryList_.GetHashCode();
      hash ^= avatarEntryList_.GetHashCode();
      hash ^= combatEntryList_.GetHashCode();
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
      abilityEntryList_.WriteTo(output, _repeated_abilityEntryList_codec);
      combatEntryList_.WriteTo(output, _repeated_combatEntryList_codec);
      avatarEntryList_.WriteTo(output, _repeated_avatarEntryList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      abilityEntryList_.WriteTo(ref output, _repeated_abilityEntryList_codec);
      combatEntryList_.WriteTo(ref output, _repeated_combatEntryList_codec);
      avatarEntryList_.WriteTo(ref output, _repeated_avatarEntryList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += abilityEntryList_.CalculateSize(_repeated_abilityEntryList_codec);
      size += avatarEntryList_.CalculateSize(_repeated_avatarEntryList_codec);
      size += combatEntryList_.CalculateSize(_repeated_combatEntryList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EntityConfigHashNotify other) {
      if (other == null) {
        return;
      }
      abilityEntryList_.Add(other.abilityEntryList_);
      avatarEntryList_.Add(other.avatarEntryList_);
      combatEntryList_.Add(other.combatEntryList_);
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
          case 26: {
            abilityEntryList_.AddEntriesFrom(input, _repeated_abilityEntryList_codec);
            break;
          }
          case 66: {
            combatEntryList_.AddEntriesFrom(input, _repeated_combatEntryList_codec);
            break;
          }
          case 122: {
            avatarEntryList_.AddEntriesFrom(input, _repeated_avatarEntryList_codec);
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
          case 26: {
            abilityEntryList_.AddEntriesFrom(ref input, _repeated_abilityEntryList_codec);
            break;
          }
          case 66: {
            combatEntryList_.AddEntriesFrom(ref input, _repeated_combatEntryList_codec);
            break;
          }
          case 122: {
            avatarEntryList_.AddEntriesFrom(ref input, _repeated_avatarEntryList_codec);
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