// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerHomeCompInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PlayerHomeCompInfo.proto</summary>
  public static partial class PlayerHomeCompInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerHomeCompInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerHomeCompInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhQbGF5ZXJIb21lQ29tcEluZm8ucHJvdG8aG0ZyaWVuZEVudGVySG9tZU9w",
            "dGlvbi5wcm90byKzAQoSUGxheWVySG9tZUNvbXBJbmZvEh8KF3VubG9ja2Vk",
            "X21vZHVsZV9pZF9saXN0GAQgAygNEhsKE3NlZW5fbW9kdWxlX2lkX2xpc3QY",
            "AiADKA0SJQodbGV2ZWx1cF9yZXdhcmRfZ290X2xldmVsX2xpc3QYByADKA0S",
            "OAoYZnJpZW5kX2VudGVyX2hvbWVfb3B0aW9uGAggASgOMhYuRnJpZW5kRW50",
            "ZXJIb21lT3B0aW9uQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOptionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PlayerHomeCompInfo), global::Weedwacker.Shared.Network.Proto.PlayerHomeCompInfo.Parser, new[]{ "UnlockedModuleIdList", "SeenModuleIdList", "LevelupRewardGotLevelList", "FriendEnterHomeOption" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerHomeCompInfo : pb::IMessage<PlayerHomeCompInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerHomeCompInfo> _parser = new pb::MessageParser<PlayerHomeCompInfo>(() => new PlayerHomeCompInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerHomeCompInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PlayerHomeCompInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerHomeCompInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerHomeCompInfo(PlayerHomeCompInfo other) : this() {
      unlockedModuleIdList_ = other.unlockedModuleIdList_.Clone();
      seenModuleIdList_ = other.seenModuleIdList_.Clone();
      levelupRewardGotLevelList_ = other.levelupRewardGotLevelList_.Clone();
      friendEnterHomeOption_ = other.friendEnterHomeOption_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerHomeCompInfo Clone() {
      return new PlayerHomeCompInfo(this);
    }

    /// <summary>Field number for the "unlocked_module_id_list" field.</summary>
    public const int UnlockedModuleIdListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_unlockedModuleIdList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> unlockedModuleIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockedModuleIdList {
      get { return unlockedModuleIdList_; }
    }

    /// <summary>Field number for the "seen_module_id_list" field.</summary>
    public const int SeenModuleIdListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_seenModuleIdList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> seenModuleIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SeenModuleIdList {
      get { return seenModuleIdList_; }
    }

    /// <summary>Field number for the "levelup_reward_got_level_list" field.</summary>
    public const int LevelupRewardGotLevelListFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_levelupRewardGotLevelList_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> levelupRewardGotLevelList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LevelupRewardGotLevelList {
      get { return levelupRewardGotLevelList_; }
    }

    /// <summary>Field number for the "friend_enter_home_option" field.</summary>
    public const int FriendEnterHomeOptionFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption friendEnterHomeOption_ = global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption.NeedConfirm;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption FriendEnterHomeOption {
      get { return friendEnterHomeOption_; }
      set {
        friendEnterHomeOption_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerHomeCompInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerHomeCompInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unlockedModuleIdList_.Equals(other.unlockedModuleIdList_)) return false;
      if(!seenModuleIdList_.Equals(other.seenModuleIdList_)) return false;
      if(!levelupRewardGotLevelList_.Equals(other.levelupRewardGotLevelList_)) return false;
      if (FriendEnterHomeOption != other.FriendEnterHomeOption) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unlockedModuleIdList_.GetHashCode();
      hash ^= seenModuleIdList_.GetHashCode();
      hash ^= levelupRewardGotLevelList_.GetHashCode();
      if (FriendEnterHomeOption != global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption.NeedConfirm) hash ^= FriendEnterHomeOption.GetHashCode();
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
      seenModuleIdList_.WriteTo(output, _repeated_seenModuleIdList_codec);
      unlockedModuleIdList_.WriteTo(output, _repeated_unlockedModuleIdList_codec);
      levelupRewardGotLevelList_.WriteTo(output, _repeated_levelupRewardGotLevelList_codec);
      if (FriendEnterHomeOption != global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption.NeedConfirm) {
        output.WriteRawTag(64);
        output.WriteEnum((int) FriendEnterHomeOption);
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
      seenModuleIdList_.WriteTo(ref output, _repeated_seenModuleIdList_codec);
      unlockedModuleIdList_.WriteTo(ref output, _repeated_unlockedModuleIdList_codec);
      levelupRewardGotLevelList_.WriteTo(ref output, _repeated_levelupRewardGotLevelList_codec);
      if (FriendEnterHomeOption != global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption.NeedConfirm) {
        output.WriteRawTag(64);
        output.WriteEnum((int) FriendEnterHomeOption);
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
      size += unlockedModuleIdList_.CalculateSize(_repeated_unlockedModuleIdList_codec);
      size += seenModuleIdList_.CalculateSize(_repeated_seenModuleIdList_codec);
      size += levelupRewardGotLevelList_.CalculateSize(_repeated_levelupRewardGotLevelList_codec);
      if (FriendEnterHomeOption != global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption.NeedConfirm) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FriendEnterHomeOption);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerHomeCompInfo other) {
      if (other == null) {
        return;
      }
      unlockedModuleIdList_.Add(other.unlockedModuleIdList_);
      seenModuleIdList_.Add(other.seenModuleIdList_);
      levelupRewardGotLevelList_.Add(other.levelupRewardGotLevelList_);
      if (other.FriendEnterHomeOption != global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption.NeedConfirm) {
        FriendEnterHomeOption = other.FriendEnterHomeOption;
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
          case 18:
          case 16: {
            seenModuleIdList_.AddEntriesFrom(input, _repeated_seenModuleIdList_codec);
            break;
          }
          case 34:
          case 32: {
            unlockedModuleIdList_.AddEntriesFrom(input, _repeated_unlockedModuleIdList_codec);
            break;
          }
          case 58:
          case 56: {
            levelupRewardGotLevelList_.AddEntriesFrom(input, _repeated_levelupRewardGotLevelList_codec);
            break;
          }
          case 64: {
            FriendEnterHomeOption = (global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption) input.ReadEnum();
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
          case 18:
          case 16: {
            seenModuleIdList_.AddEntriesFrom(ref input, _repeated_seenModuleIdList_codec);
            break;
          }
          case 34:
          case 32: {
            unlockedModuleIdList_.AddEntriesFrom(ref input, _repeated_unlockedModuleIdList_codec);
            break;
          }
          case 58:
          case 56: {
            levelupRewardGotLevelList_.AddEntriesFrom(ref input, _repeated_levelupRewardGotLevelList_codec);
            break;
          }
          case 64: {
            FriendEnterHomeOption = (global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption) input.ReadEnum();
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
