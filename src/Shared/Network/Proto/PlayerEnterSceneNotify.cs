// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerEnterSceneNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PlayerEnterSceneNotify.proto</summary>
  public static partial class PlayerEnterSceneNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerEnterSceneNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerEnterSceneNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxQbGF5ZXJFbnRlclNjZW5lTm90aWZ5LnByb3RvGg9FbnRlclR5cGUucHJv",
            "dG8aDFZlY3Rvci5wcm90byKaAwoWUGxheWVyRW50ZXJTY2VuZU5vdGlmeRIV",
            "Cg1wcmV2X3NjZW5lX2lkGAYgASgNEhIKCmR1bmdlb25faWQYDCABKA0SEwoK",
            "aXNfc2tpcF91aRjEDSABKAgSEAoIc2NlbmVfaWQYDyABKA0SGAoEdHlwZRgN",
            "IAEoDjIKLkVudGVyVHlwZRIYChBzY2VuZV9iZWdpbl90aW1lGA4gASgEEhMK",
            "C3dvcmxkX2xldmVsGAsgASgNEhMKCndvcmxkX3R5cGUY0gsgASgNEhIKCnRh",
            "cmdldF91aWQYBCABKA0SIgoaaXNfZmlyc3RfbG9naW5fZW50ZXJfc2NlbmUY",
            "AyABKAgSGQoRc2NlbmVfdGFnX2lkX2xpc3QYBSADKA0SGgoRc2NlbmVfdHJh",
            "bnNhY3Rpb24Ysg4gASgJEhkKCHByZXZfcG9zGAggASgLMgcuVmVjdG9yEhUK",
            "DGVudGVyX3JlYXNvbhikDiABKA0SFAoDcG9zGAcgASgLMgcuVmVjdG9yEhkK",
            "EWVudGVyX3NjZW5lX3Rva2VuGAIgASgNQiKqAh9XZWVkd2Fja2VyLlNoYXJl",
            "ZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.EnterTypeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PlayerEnterSceneNotify), global::Weedwacker.Shared.Network.Proto.PlayerEnterSceneNotify.Parser, new[]{ "PrevSceneId", "DungeonId", "IsSkipUi", "SceneId", "Type", "SceneBeginTime", "WorldLevel", "WorldType", "TargetUid", "IsFirstLoginEnterScene", "SceneTagIdList", "SceneTransaction", "PrevPos", "EnterReason", "Pos", "EnterSceneToken" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 272
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class PlayerEnterSceneNotify : pb::IMessage<PlayerEnterSceneNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerEnterSceneNotify> _parser = new pb::MessageParser<PlayerEnterSceneNotify>(() => new PlayerEnterSceneNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerEnterSceneNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PlayerEnterSceneNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEnterSceneNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEnterSceneNotify(PlayerEnterSceneNotify other) : this() {
      prevSceneId_ = other.prevSceneId_;
      dungeonId_ = other.dungeonId_;
      isSkipUi_ = other.isSkipUi_;
      sceneId_ = other.sceneId_;
      type_ = other.type_;
      sceneBeginTime_ = other.sceneBeginTime_;
      worldLevel_ = other.worldLevel_;
      worldType_ = other.worldType_;
      targetUid_ = other.targetUid_;
      isFirstLoginEnterScene_ = other.isFirstLoginEnterScene_;
      sceneTagIdList_ = other.sceneTagIdList_.Clone();
      sceneTransaction_ = other.sceneTransaction_;
      prevPos_ = other.prevPos_ != null ? other.prevPos_.Clone() : null;
      enterReason_ = other.enterReason_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      enterSceneToken_ = other.enterSceneToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEnterSceneNotify Clone() {
      return new PlayerEnterSceneNotify(this);
    }

    /// <summary>Field number for the "prev_scene_id" field.</summary>
    public const int PrevSceneIdFieldNumber = 6;
    private uint prevSceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PrevSceneId {
      get { return prevSceneId_; }
      set {
        prevSceneId_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 12;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "is_skip_ui" field.</summary>
    public const int IsSkipUiFieldNumber = 1732;
    private bool isSkipUi_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSkipUi {
      get { return isSkipUi_; }
      set {
        isSkipUi_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 15;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 13;
    private global::Weedwacker.Shared.Network.Proto.EnterType type_ = global::Weedwacker.Shared.Network.Proto.EnterType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.EnterType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "scene_begin_time" field.</summary>
    public const int SceneBeginTimeFieldNumber = 14;
    private ulong sceneBeginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong SceneBeginTime {
      get { return sceneBeginTime_; }
      set {
        sceneBeginTime_ = value;
      }
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 11;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "world_type" field.</summary>
    public const int WorldTypeFieldNumber = 1490;
    private uint worldType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldType {
      get { return worldType_; }
      set {
        worldType_ = value;
      }
    }

    /// <summary>Field number for the "target_uid" field.</summary>
    public const int TargetUidFieldNumber = 4;
    private uint targetUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetUid {
      get { return targetUid_; }
      set {
        targetUid_ = value;
      }
    }

    /// <summary>Field number for the "is_first_login_enter_scene" field.</summary>
    public const int IsFirstLoginEnterSceneFieldNumber = 3;
    private bool isFirstLoginEnterScene_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFirstLoginEnterScene {
      get { return isFirstLoginEnterScene_; }
      set {
        isFirstLoginEnterScene_ = value;
      }
    }

    /// <summary>Field number for the "scene_tag_id_list" field.</summary>
    public const int SceneTagIdListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_sceneTagIdList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> sceneTagIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SceneTagIdList {
      get { return sceneTagIdList_; }
    }

    /// <summary>Field number for the "scene_transaction" field.</summary>
    public const int SceneTransactionFieldNumber = 1842;
    private string sceneTransaction_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SceneTransaction {
      get { return sceneTransaction_; }
      set {
        sceneTransaction_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "prev_pos" field.</summary>
    public const int PrevPosFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.Vector prevPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector PrevPos {
      get { return prevPos_; }
      set {
        prevPos_ = value;
      }
    }

    /// <summary>Field number for the "enter_reason" field.</summary>
    public const int EnterReasonFieldNumber = 1828;
    private uint enterReason_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EnterReason {
      get { return enterReason_; }
      set {
        enterReason_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "enter_scene_token" field.</summary>
    public const int EnterSceneTokenFieldNumber = 2;
    private uint enterSceneToken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EnterSceneToken {
      get { return enterSceneToken_; }
      set {
        enterSceneToken_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerEnterSceneNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerEnterSceneNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PrevSceneId != other.PrevSceneId) return false;
      if (DungeonId != other.DungeonId) return false;
      if (IsSkipUi != other.IsSkipUi) return false;
      if (SceneId != other.SceneId) return false;
      if (Type != other.Type) return false;
      if (SceneBeginTime != other.SceneBeginTime) return false;
      if (WorldLevel != other.WorldLevel) return false;
      if (WorldType != other.WorldType) return false;
      if (TargetUid != other.TargetUid) return false;
      if (IsFirstLoginEnterScene != other.IsFirstLoginEnterScene) return false;
      if(!sceneTagIdList_.Equals(other.sceneTagIdList_)) return false;
      if (SceneTransaction != other.SceneTransaction) return false;
      if (!object.Equals(PrevPos, other.PrevPos)) return false;
      if (EnterReason != other.EnterReason) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (EnterSceneToken != other.EnterSceneToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PrevSceneId != 0) hash ^= PrevSceneId.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      if (IsSkipUi != false) hash ^= IsSkipUi.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (Type != global::Weedwacker.Shared.Network.Proto.EnterType.None) hash ^= Type.GetHashCode();
      if (SceneBeginTime != 0UL) hash ^= SceneBeginTime.GetHashCode();
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      if (WorldType != 0) hash ^= WorldType.GetHashCode();
      if (TargetUid != 0) hash ^= TargetUid.GetHashCode();
      if (IsFirstLoginEnterScene != false) hash ^= IsFirstLoginEnterScene.GetHashCode();
      hash ^= sceneTagIdList_.GetHashCode();
      if (SceneTransaction.Length != 0) hash ^= SceneTransaction.GetHashCode();
      if (prevPos_ != null) hash ^= PrevPos.GetHashCode();
      if (EnterReason != 0) hash ^= EnterReason.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (EnterSceneToken != 0) hash ^= EnterSceneToken.GetHashCode();
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
      if (EnterSceneToken != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EnterSceneToken);
      }
      if (IsFirstLoginEnterScene != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsFirstLoginEnterScene);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TargetUid);
      }
      sceneTagIdList_.WriteTo(output, _repeated_sceneTagIdList_codec);
      if (PrevSceneId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PrevSceneId);
      }
      if (pos_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Pos);
      }
      if (prevPos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(PrevPos);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WorldLevel);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DungeonId);
      }
      if (Type != global::Weedwacker.Shared.Network.Proto.EnterType.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Type);
      }
      if (SceneBeginTime != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(SceneBeginTime);
      }
      if (SceneId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SceneId);
      }
      if (WorldType != 0) {
        output.WriteRawTag(144, 93);
        output.WriteUInt32(WorldType);
      }
      if (IsSkipUi != false) {
        output.WriteRawTag(160, 108);
        output.WriteBool(IsSkipUi);
      }
      if (EnterReason != 0) {
        output.WriteRawTag(160, 114);
        output.WriteUInt32(EnterReason);
      }
      if (SceneTransaction.Length != 0) {
        output.WriteRawTag(146, 115);
        output.WriteString(SceneTransaction);
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
      if (EnterSceneToken != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EnterSceneToken);
      }
      if (IsFirstLoginEnterScene != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsFirstLoginEnterScene);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TargetUid);
      }
      sceneTagIdList_.WriteTo(ref output, _repeated_sceneTagIdList_codec);
      if (PrevSceneId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PrevSceneId);
      }
      if (pos_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Pos);
      }
      if (prevPos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(PrevPos);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WorldLevel);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DungeonId);
      }
      if (Type != global::Weedwacker.Shared.Network.Proto.EnterType.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Type);
      }
      if (SceneBeginTime != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(SceneBeginTime);
      }
      if (SceneId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SceneId);
      }
      if (WorldType != 0) {
        output.WriteRawTag(144, 93);
        output.WriteUInt32(WorldType);
      }
      if (IsSkipUi != false) {
        output.WriteRawTag(160, 108);
        output.WriteBool(IsSkipUi);
      }
      if (EnterReason != 0) {
        output.WriteRawTag(160, 114);
        output.WriteUInt32(EnterReason);
      }
      if (SceneTransaction.Length != 0) {
        output.WriteRawTag(146, 115);
        output.WriteString(SceneTransaction);
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
      if (PrevSceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PrevSceneId);
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (IsSkipUi != false) {
        size += 2 + 1;
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (Type != global::Weedwacker.Shared.Network.Proto.EnterType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (SceneBeginTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(SceneBeginTime);
      }
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      if (WorldType != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(WorldType);
      }
      if (TargetUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetUid);
      }
      if (IsFirstLoginEnterScene != false) {
        size += 1 + 1;
      }
      size += sceneTagIdList_.CalculateSize(_repeated_sceneTagIdList_codec);
      if (SceneTransaction.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(SceneTransaction);
      }
      if (prevPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PrevPos);
      }
      if (EnterReason != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(EnterReason);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (EnterSceneToken != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EnterSceneToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerEnterSceneNotify other) {
      if (other == null) {
        return;
      }
      if (other.PrevSceneId != 0) {
        PrevSceneId = other.PrevSceneId;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      if (other.IsSkipUi != false) {
        IsSkipUi = other.IsSkipUi;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.Type != global::Weedwacker.Shared.Network.Proto.EnterType.None) {
        Type = other.Type;
      }
      if (other.SceneBeginTime != 0UL) {
        SceneBeginTime = other.SceneBeginTime;
      }
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      if (other.WorldType != 0) {
        WorldType = other.WorldType;
      }
      if (other.TargetUid != 0) {
        TargetUid = other.TargetUid;
      }
      if (other.IsFirstLoginEnterScene != false) {
        IsFirstLoginEnterScene = other.IsFirstLoginEnterScene;
      }
      sceneTagIdList_.Add(other.sceneTagIdList_);
      if (other.SceneTransaction.Length != 0) {
        SceneTransaction = other.SceneTransaction;
      }
      if (other.prevPos_ != null) {
        if (prevPos_ == null) {
          PrevPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        PrevPos.MergeFrom(other.PrevPos);
      }
      if (other.EnterReason != 0) {
        EnterReason = other.EnterReason;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.EnterSceneToken != 0) {
        EnterSceneToken = other.EnterSceneToken;
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
            EnterSceneToken = input.ReadUInt32();
            break;
          }
          case 24: {
            IsFirstLoginEnterScene = input.ReadBool();
            break;
          }
          case 32: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            sceneTagIdList_.AddEntriesFrom(input, _repeated_sceneTagIdList_codec);
            break;
          }
          case 48: {
            PrevSceneId = input.ReadUInt32();
            break;
          }
          case 58: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 66: {
            if (prevPos_ == null) {
              PrevPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(PrevPos);
            break;
          }
          case 88: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 96: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 104: {
            Type = (global::Weedwacker.Shared.Network.Proto.EnterType) input.ReadEnum();
            break;
          }
          case 112: {
            SceneBeginTime = input.ReadUInt64();
            break;
          }
          case 120: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 11920: {
            WorldType = input.ReadUInt32();
            break;
          }
          case 13856: {
            IsSkipUi = input.ReadBool();
            break;
          }
          case 14624: {
            EnterReason = input.ReadUInt32();
            break;
          }
          case 14738: {
            SceneTransaction = input.ReadString();
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
            EnterSceneToken = input.ReadUInt32();
            break;
          }
          case 24: {
            IsFirstLoginEnterScene = input.ReadBool();
            break;
          }
          case 32: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            sceneTagIdList_.AddEntriesFrom(ref input, _repeated_sceneTagIdList_codec);
            break;
          }
          case 48: {
            PrevSceneId = input.ReadUInt32();
            break;
          }
          case 58: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 66: {
            if (prevPos_ == null) {
              PrevPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(PrevPos);
            break;
          }
          case 88: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 96: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 104: {
            Type = (global::Weedwacker.Shared.Network.Proto.EnterType) input.ReadEnum();
            break;
          }
          case 112: {
            SceneBeginTime = input.ReadUInt64();
            break;
          }
          case 120: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 11920: {
            WorldType = input.ReadUInt32();
            break;
          }
          case 13856: {
            IsSkipUi = input.ReadBool();
            break;
          }
          case 14624: {
            EnterReason = input.ReadUInt32();
            break;
          }
          case 14738: {
            SceneTransaction = input.ReadString();
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
