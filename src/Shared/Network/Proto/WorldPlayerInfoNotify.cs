// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WorldPlayerInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from WorldPlayerInfoNotify.proto</summary>
  public static partial class WorldPlayerInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for WorldPlayerInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WorldPlayerInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtXb3JsZFBsYXllckluZm9Ob3RpZnkucHJvdG8aFk9ubGluZVBsYXllcklu",
            "Zm8ucHJvdG8aGVVuazMwMDBfSEtIRkZERU1OS04ucHJvdG8ikAEKFVdvcmxk",
            "UGxheWVySW5mb05vdGlmeRIxChNVbmszMDAwX0dDSkxKQ0pBQURHGAggAygL",
            "MhQuVW5rMzAwMF9IS0hGRkRFTU5LThIrChBwbGF5ZXJfaW5mb19saXN0GA4g",
            "AygLMhEuT25saW5lUGxheWVySW5mbxIXCg9wbGF5ZXJfdWlkX2xpc3QYCyAD",
            "KA1CIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.Unk3000HKHFFDEMNKNReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.WorldPlayerInfoNotify), global::Weedwacker.Shared.Network.Proto.WorldPlayerInfoNotify.Parser, new[]{ "Unk3000GCJLJCJAADG", "PlayerInfoList", "PlayerUidList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 3116
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class WorldPlayerInfoNotify : pb::IMessage<WorldPlayerInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WorldPlayerInfoNotify> _parser = new pb::MessageParser<WorldPlayerInfoNotify>(() => new WorldPlayerInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WorldPlayerInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.WorldPlayerInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldPlayerInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldPlayerInfoNotify(WorldPlayerInfoNotify other) : this() {
      unk3000GCJLJCJAADG_ = other.unk3000GCJLJCJAADG_.Clone();
      playerInfoList_ = other.playerInfoList_.Clone();
      playerUidList_ = other.playerUidList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldPlayerInfoNotify Clone() {
      return new WorldPlayerInfoNotify(this);
    }

    /// <summary>Field number for the "Unk3000_GCJLJCJAADG" field.</summary>
    public const int Unk3000GCJLJCJAADGFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.Unk3000_HKHFFDEMNKN> _repeated_unk3000GCJLJCJAADG_codec
        = pb::FieldCodec.ForMessage(66, global::Weedwacker.Shared.Network.Proto.Unk3000_HKHFFDEMNKN.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk3000_HKHFFDEMNKN> unk3000GCJLJCJAADG_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk3000_HKHFFDEMNKN>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk3000_HKHFFDEMNKN> Unk3000GCJLJCJAADG {
      get { return unk3000GCJLJCJAADG_; }
    }

    /// <summary>Field number for the "player_info_list" field.</summary>
    public const int PlayerInfoListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo> _repeated_playerInfoList_codec
        = pb::FieldCodec.ForMessage(114, global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo> playerInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo> PlayerInfoList {
      get { return playerInfoList_; }
    }

    /// <summary>Field number for the "player_uid_list" field.</summary>
    public const int PlayerUidListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_playerUidList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> playerUidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> PlayerUidList {
      get { return playerUidList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WorldPlayerInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WorldPlayerInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk3000GCJLJCJAADG_.Equals(other.unk3000GCJLJCJAADG_)) return false;
      if(!playerInfoList_.Equals(other.playerInfoList_)) return false;
      if(!playerUidList_.Equals(other.playerUidList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk3000GCJLJCJAADG_.GetHashCode();
      hash ^= playerInfoList_.GetHashCode();
      hash ^= playerUidList_.GetHashCode();
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
      unk3000GCJLJCJAADG_.WriteTo(output, _repeated_unk3000GCJLJCJAADG_codec);
      playerUidList_.WriteTo(output, _repeated_playerUidList_codec);
      playerInfoList_.WriteTo(output, _repeated_playerInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unk3000GCJLJCJAADG_.WriteTo(ref output, _repeated_unk3000GCJLJCJAADG_codec);
      playerUidList_.WriteTo(ref output, _repeated_playerUidList_codec);
      playerInfoList_.WriteTo(ref output, _repeated_playerInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unk3000GCJLJCJAADG_.CalculateSize(_repeated_unk3000GCJLJCJAADG_codec);
      size += playerInfoList_.CalculateSize(_repeated_playerInfoList_codec);
      size += playerUidList_.CalculateSize(_repeated_playerUidList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WorldPlayerInfoNotify other) {
      if (other == null) {
        return;
      }
      unk3000GCJLJCJAADG_.Add(other.unk3000GCJLJCJAADG_);
      playerInfoList_.Add(other.playerInfoList_);
      playerUidList_.Add(other.playerUidList_);
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
          case 66: {
            unk3000GCJLJCJAADG_.AddEntriesFrom(input, _repeated_unk3000GCJLJCJAADG_codec);
            break;
          }
          case 90:
          case 88: {
            playerUidList_.AddEntriesFrom(input, _repeated_playerUidList_codec);
            break;
          }
          case 114: {
            playerInfoList_.AddEntriesFrom(input, _repeated_playerInfoList_codec);
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
          case 66: {
            unk3000GCJLJCJAADG_.AddEntriesFrom(ref input, _repeated_unk3000GCJLJCJAADG_codec);
            break;
          }
          case 90:
          case 88: {
            playerUidList_.AddEntriesFrom(ref input, _repeated_playerUidList_codec);
            break;
          }
          case 114: {
            playerInfoList_.AddEntriesFrom(ref input, _repeated_playerInfoList_codec);
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
