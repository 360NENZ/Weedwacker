// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InBattleMechanicusInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from InBattleMechanicusInfo.proto</summary>
  public static partial class InBattleMechanicusInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for InBattleMechanicusInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InBattleMechanicusInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxJbkJhdHRsZU1lY2hhbmljdXNJbmZvLnByb3RvGiBJbkJhdHRsZU1lY2hh",
            "bmljdXNDYXJkSW5mby5wcm90bxojSW5CYXR0bGVNZWNoYW5pY3VzTW9uc3Rl",
            "ckluZm8ucHJvdG8aIkluQmF0dGxlTWVjaGFuaWN1c1BsYXllckluZm8ucHJv",
            "dG8aIUluQmF0dGxlTWVjaGFuaWN1c1N0YWdlVHlwZS5wcm90byK9BAoWSW5C",
            "YXR0bGVNZWNoYW5pY3VzSW5mbxIUCgxsZWZ0X21vbnN0ZXIYBSABKA0SFAoM",
            "d2FpdF9zZWNvbmRzGA0gASgNEhYKDWVudHJhbmNlX2xpc3QYmgMgAygNEhEK",
            "CWV4aXRfbGlzdBhzIAMoDRI2ChFoaXN0b3J5X2NhcmRfbGlzdBgLIAMoCzIb",
            "LkluQmF0dGxlTWVjaGFuaWN1c0NhcmRJbmZvEh4KFm1heF9lc2NhcGVfbW9u",
            "c3Rlcl9udW0YCiABKA0SHwoXYnVpbGRpbmdfc3RhZ2VfZHVyYXRpb24YBCAB",
            "KA0SEwoLZHVyYXRpb25fbXMYCCABKAQSKwoFc3RhZ2UYCSABKA4yHC5JbkJh",
            "dHRsZU1lY2hhbmljdXNTdGFnZVR5cGUSEwoLdG90YWxfcm91bmQYDCABKA0S",
            "NAoMbW9uc3Rlcl9saXN0GA4gAygLMh4uSW5CYXR0bGVNZWNoYW5pY3VzTW9u",
            "c3RlckluZm8SGwoTZXNjYXBlZF9tb25zdGVyX251bRgGIAEoDRINCgVyb3Vu",
            "ZBgDIAEoDRIzCg5waWNrX2NhcmRfbGlzdBgPIAMoCzIbLkluQmF0dGxlTWVj",
            "aGFuaWN1c0NhcmRJbmZvEjIKC3BsYXllcl9saXN0GAcgAygLMh0uSW5CYXR0",
            "bGVNZWNoYW5pY3VzUGxheWVySW5mbxIaChJ3YWl0X2JlZ2luX3RpbWVfdXMY",
            "ASABKAQSFQoNYmVnaW5fdGltZV9tcxgCIAEoBEIaqgIXV2VlZHdhY2tlci5T",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.InBattleMechanicusCardInfoReflection.Descriptor, global::Weedwacker.Server.Proto.InBattleMechanicusMonsterInfoReflection.Descriptor, global::Weedwacker.Server.Proto.InBattleMechanicusPlayerInfoReflection.Descriptor, global::Weedwacker.Server.Proto.InBattleMechanicusStageTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.InBattleMechanicusInfo), global::Weedwacker.Server.Proto.InBattleMechanicusInfo.Parser, new[]{ "LeftMonster", "WaitSeconds", "EntranceList", "ExitList", "HistoryCardList", "MaxEscapeMonsterNum", "BuildingStageDuration", "DurationMs", "Stage", "TotalRound", "MonsterList", "EscapedMonsterNum", "Round", "PickCardList", "PlayerList", "WaitBeginTimeUs", "BeginTimeMs" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InBattleMechanicusInfo : pb::IMessage<InBattleMechanicusInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InBattleMechanicusInfo> _parser = new pb::MessageParser<InBattleMechanicusInfo>(() => new InBattleMechanicusInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InBattleMechanicusInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.InBattleMechanicusInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleMechanicusInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleMechanicusInfo(InBattleMechanicusInfo other) : this() {
      leftMonster_ = other.leftMonster_;
      waitSeconds_ = other.waitSeconds_;
      entranceList_ = other.entranceList_.Clone();
      exitList_ = other.exitList_.Clone();
      historyCardList_ = other.historyCardList_.Clone();
      maxEscapeMonsterNum_ = other.maxEscapeMonsterNum_;
      buildingStageDuration_ = other.buildingStageDuration_;
      durationMs_ = other.durationMs_;
      stage_ = other.stage_;
      totalRound_ = other.totalRound_;
      monsterList_ = other.monsterList_.Clone();
      escapedMonsterNum_ = other.escapedMonsterNum_;
      round_ = other.round_;
      pickCardList_ = other.pickCardList_.Clone();
      playerList_ = other.playerList_.Clone();
      waitBeginTimeUs_ = other.waitBeginTimeUs_;
      beginTimeMs_ = other.beginTimeMs_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleMechanicusInfo Clone() {
      return new InBattleMechanicusInfo(this);
    }

    /// <summary>Field number for the "left_monster" field.</summary>
    public const int LeftMonsterFieldNumber = 5;
    private uint leftMonster_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LeftMonster {
      get { return leftMonster_; }
      set {
        leftMonster_ = value;
      }
    }

    /// <summary>Field number for the "wait_seconds" field.</summary>
    public const int WaitSecondsFieldNumber = 13;
    private uint waitSeconds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WaitSeconds {
      get { return waitSeconds_; }
      set {
        waitSeconds_ = value;
      }
    }

    /// <summary>Field number for the "entrance_list" field.</summary>
    public const int EntranceListFieldNumber = 410;
    private static readonly pb::FieldCodec<uint> _repeated_entranceList_codec
        = pb::FieldCodec.ForUInt32(3282);
    private readonly pbc::RepeatedField<uint> entranceList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EntranceList {
      get { return entranceList_; }
    }

    /// <summary>Field number for the "exit_list" field.</summary>
    public const int ExitListFieldNumber = 115;
    private static readonly pb::FieldCodec<uint> _repeated_exitList_codec
        = pb::FieldCodec.ForUInt32(922);
    private readonly pbc::RepeatedField<uint> exitList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ExitList {
      get { return exitList_; }
    }

    /// <summary>Field number for the "history_card_list" field.</summary>
    public const int HistoryCardListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.InBattleMechanicusCardInfo> _repeated_historyCardList_codec
        = pb::FieldCodec.ForMessage(90, global::Weedwacker.Server.Proto.InBattleMechanicusCardInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.InBattleMechanicusCardInfo> historyCardList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.InBattleMechanicusCardInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.InBattleMechanicusCardInfo> HistoryCardList {
      get { return historyCardList_; }
    }

    /// <summary>Field number for the "max_escape_monster_num" field.</summary>
    public const int MaxEscapeMonsterNumFieldNumber = 10;
    private uint maxEscapeMonsterNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxEscapeMonsterNum {
      get { return maxEscapeMonsterNum_; }
      set {
        maxEscapeMonsterNum_ = value;
      }
    }

    /// <summary>Field number for the "building_stage_duration" field.</summary>
    public const int BuildingStageDurationFieldNumber = 4;
    private uint buildingStageDuration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuildingStageDuration {
      get { return buildingStageDuration_; }
      set {
        buildingStageDuration_ = value;
      }
    }

    /// <summary>Field number for the "duration_ms" field.</summary>
    public const int DurationMsFieldNumber = 8;
    private ulong durationMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong DurationMs {
      get { return durationMs_; }
      set {
        durationMs_ = value;
      }
    }

    /// <summary>Field number for the "stage" field.</summary>
    public const int StageFieldNumber = 9;
    private global::Weedwacker.Server.Proto.InBattleMechanicusStageType stage_ = global::Weedwacker.Server.Proto.InBattleMechanicusStageType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.InBattleMechanicusStageType Stage {
      get { return stage_; }
      set {
        stage_ = value;
      }
    }

    /// <summary>Field number for the "total_round" field.</summary>
    public const int TotalRoundFieldNumber = 12;
    private uint totalRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalRound {
      get { return totalRound_; }
      set {
        totalRound_ = value;
      }
    }

    /// <summary>Field number for the "monster_list" field.</summary>
    public const int MonsterListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.InBattleMechanicusMonsterInfo> _repeated_monsterList_codec
        = pb::FieldCodec.ForMessage(114, global::Weedwacker.Server.Proto.InBattleMechanicusMonsterInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.InBattleMechanicusMonsterInfo> monsterList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.InBattleMechanicusMonsterInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.InBattleMechanicusMonsterInfo> MonsterList {
      get { return monsterList_; }
    }

    /// <summary>Field number for the "escaped_monster_num" field.</summary>
    public const int EscapedMonsterNumFieldNumber = 6;
    private uint escapedMonsterNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EscapedMonsterNum {
      get { return escapedMonsterNum_; }
      set {
        escapedMonsterNum_ = value;
      }
    }

    /// <summary>Field number for the "round" field.</summary>
    public const int RoundFieldNumber = 3;
    private uint round_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Round {
      get { return round_; }
      set {
        round_ = value;
      }
    }

    /// <summary>Field number for the "pick_card_list" field.</summary>
    public const int PickCardListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.InBattleMechanicusCardInfo> _repeated_pickCardList_codec
        = pb::FieldCodec.ForMessage(122, global::Weedwacker.Server.Proto.InBattleMechanicusCardInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.InBattleMechanicusCardInfo> pickCardList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.InBattleMechanicusCardInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.InBattleMechanicusCardInfo> PickCardList {
      get { return pickCardList_; }
    }

    /// <summary>Field number for the "player_list" field.</summary>
    public const int PlayerListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.InBattleMechanicusPlayerInfo> _repeated_playerList_codec
        = pb::FieldCodec.ForMessage(58, global::Weedwacker.Server.Proto.InBattleMechanicusPlayerInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.InBattleMechanicusPlayerInfo> playerList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.InBattleMechanicusPlayerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.InBattleMechanicusPlayerInfo> PlayerList {
      get { return playerList_; }
    }

    /// <summary>Field number for the "wait_begin_time_us" field.</summary>
    public const int WaitBeginTimeUsFieldNumber = 1;
    private ulong waitBeginTimeUs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong WaitBeginTimeUs {
      get { return waitBeginTimeUs_; }
      set {
        waitBeginTimeUs_ = value;
      }
    }

    /// <summary>Field number for the "begin_time_ms" field.</summary>
    public const int BeginTimeMsFieldNumber = 2;
    private ulong beginTimeMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong BeginTimeMs {
      get { return beginTimeMs_; }
      set {
        beginTimeMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InBattleMechanicusInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InBattleMechanicusInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LeftMonster != other.LeftMonster) return false;
      if (WaitSeconds != other.WaitSeconds) return false;
      if(!entranceList_.Equals(other.entranceList_)) return false;
      if(!exitList_.Equals(other.exitList_)) return false;
      if(!historyCardList_.Equals(other.historyCardList_)) return false;
      if (MaxEscapeMonsterNum != other.MaxEscapeMonsterNum) return false;
      if (BuildingStageDuration != other.BuildingStageDuration) return false;
      if (DurationMs != other.DurationMs) return false;
      if (Stage != other.Stage) return false;
      if (TotalRound != other.TotalRound) return false;
      if(!monsterList_.Equals(other.monsterList_)) return false;
      if (EscapedMonsterNum != other.EscapedMonsterNum) return false;
      if (Round != other.Round) return false;
      if(!pickCardList_.Equals(other.pickCardList_)) return false;
      if(!playerList_.Equals(other.playerList_)) return false;
      if (WaitBeginTimeUs != other.WaitBeginTimeUs) return false;
      if (BeginTimeMs != other.BeginTimeMs) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LeftMonster != 0) hash ^= LeftMonster.GetHashCode();
      if (WaitSeconds != 0) hash ^= WaitSeconds.GetHashCode();
      hash ^= entranceList_.GetHashCode();
      hash ^= exitList_.GetHashCode();
      hash ^= historyCardList_.GetHashCode();
      if (MaxEscapeMonsterNum != 0) hash ^= MaxEscapeMonsterNum.GetHashCode();
      if (BuildingStageDuration != 0) hash ^= BuildingStageDuration.GetHashCode();
      if (DurationMs != 0UL) hash ^= DurationMs.GetHashCode();
      if (Stage != global::Weedwacker.Server.Proto.InBattleMechanicusStageType.None) hash ^= Stage.GetHashCode();
      if (TotalRound != 0) hash ^= TotalRound.GetHashCode();
      hash ^= monsterList_.GetHashCode();
      if (EscapedMonsterNum != 0) hash ^= EscapedMonsterNum.GetHashCode();
      if (Round != 0) hash ^= Round.GetHashCode();
      hash ^= pickCardList_.GetHashCode();
      hash ^= playerList_.GetHashCode();
      if (WaitBeginTimeUs != 0UL) hash ^= WaitBeginTimeUs.GetHashCode();
      if (BeginTimeMs != 0UL) hash ^= BeginTimeMs.GetHashCode();
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
      if (WaitBeginTimeUs != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(WaitBeginTimeUs);
      }
      if (BeginTimeMs != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(BeginTimeMs);
      }
      if (Round != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Round);
      }
      if (BuildingStageDuration != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(BuildingStageDuration);
      }
      if (LeftMonster != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LeftMonster);
      }
      if (EscapedMonsterNum != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EscapedMonsterNum);
      }
      playerList_.WriteTo(output, _repeated_playerList_codec);
      if (DurationMs != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(DurationMs);
      }
      if (Stage != global::Weedwacker.Server.Proto.InBattleMechanicusStageType.None) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Stage);
      }
      if (MaxEscapeMonsterNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MaxEscapeMonsterNum);
      }
      historyCardList_.WriteTo(output, _repeated_historyCardList_codec);
      if (TotalRound != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(TotalRound);
      }
      if (WaitSeconds != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(WaitSeconds);
      }
      monsterList_.WriteTo(output, _repeated_monsterList_codec);
      pickCardList_.WriteTo(output, _repeated_pickCardList_codec);
      exitList_.WriteTo(output, _repeated_exitList_codec);
      entranceList_.WriteTo(output, _repeated_entranceList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (WaitBeginTimeUs != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(WaitBeginTimeUs);
      }
      if (BeginTimeMs != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(BeginTimeMs);
      }
      if (Round != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Round);
      }
      if (BuildingStageDuration != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(BuildingStageDuration);
      }
      if (LeftMonster != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LeftMonster);
      }
      if (EscapedMonsterNum != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EscapedMonsterNum);
      }
      playerList_.WriteTo(ref output, _repeated_playerList_codec);
      if (DurationMs != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(DurationMs);
      }
      if (Stage != global::Weedwacker.Server.Proto.InBattleMechanicusStageType.None) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Stage);
      }
      if (MaxEscapeMonsterNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MaxEscapeMonsterNum);
      }
      historyCardList_.WriteTo(ref output, _repeated_historyCardList_codec);
      if (TotalRound != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(TotalRound);
      }
      if (WaitSeconds != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(WaitSeconds);
      }
      monsterList_.WriteTo(ref output, _repeated_monsterList_codec);
      pickCardList_.WriteTo(ref output, _repeated_pickCardList_codec);
      exitList_.WriteTo(ref output, _repeated_exitList_codec);
      entranceList_.WriteTo(ref output, _repeated_entranceList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (LeftMonster != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeftMonster);
      }
      if (WaitSeconds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WaitSeconds);
      }
      size += entranceList_.CalculateSize(_repeated_entranceList_codec);
      size += exitList_.CalculateSize(_repeated_exitList_codec);
      size += historyCardList_.CalculateSize(_repeated_historyCardList_codec);
      if (MaxEscapeMonsterNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxEscapeMonsterNum);
      }
      if (BuildingStageDuration != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuildingStageDuration);
      }
      if (DurationMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DurationMs);
      }
      if (Stage != global::Weedwacker.Server.Proto.InBattleMechanicusStageType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Stage);
      }
      if (TotalRound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalRound);
      }
      size += monsterList_.CalculateSize(_repeated_monsterList_codec);
      if (EscapedMonsterNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EscapedMonsterNum);
      }
      if (Round != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Round);
      }
      size += pickCardList_.CalculateSize(_repeated_pickCardList_codec);
      size += playerList_.CalculateSize(_repeated_playerList_codec);
      if (WaitBeginTimeUs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(WaitBeginTimeUs);
      }
      if (BeginTimeMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(BeginTimeMs);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InBattleMechanicusInfo other) {
      if (other == null) {
        return;
      }
      if (other.LeftMonster != 0) {
        LeftMonster = other.LeftMonster;
      }
      if (other.WaitSeconds != 0) {
        WaitSeconds = other.WaitSeconds;
      }
      entranceList_.Add(other.entranceList_);
      exitList_.Add(other.exitList_);
      historyCardList_.Add(other.historyCardList_);
      if (other.MaxEscapeMonsterNum != 0) {
        MaxEscapeMonsterNum = other.MaxEscapeMonsterNum;
      }
      if (other.BuildingStageDuration != 0) {
        BuildingStageDuration = other.BuildingStageDuration;
      }
      if (other.DurationMs != 0UL) {
        DurationMs = other.DurationMs;
      }
      if (other.Stage != global::Weedwacker.Server.Proto.InBattleMechanicusStageType.None) {
        Stage = other.Stage;
      }
      if (other.TotalRound != 0) {
        TotalRound = other.TotalRound;
      }
      monsterList_.Add(other.monsterList_);
      if (other.EscapedMonsterNum != 0) {
        EscapedMonsterNum = other.EscapedMonsterNum;
      }
      if (other.Round != 0) {
        Round = other.Round;
      }
      pickCardList_.Add(other.pickCardList_);
      playerList_.Add(other.playerList_);
      if (other.WaitBeginTimeUs != 0UL) {
        WaitBeginTimeUs = other.WaitBeginTimeUs;
      }
      if (other.BeginTimeMs != 0UL) {
        BeginTimeMs = other.BeginTimeMs;
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
            WaitBeginTimeUs = input.ReadUInt64();
            break;
          }
          case 16: {
            BeginTimeMs = input.ReadUInt64();
            break;
          }
          case 24: {
            Round = input.ReadUInt32();
            break;
          }
          case 32: {
            BuildingStageDuration = input.ReadUInt32();
            break;
          }
          case 40: {
            LeftMonster = input.ReadUInt32();
            break;
          }
          case 48: {
            EscapedMonsterNum = input.ReadUInt32();
            break;
          }
          case 58: {
            playerList_.AddEntriesFrom(input, _repeated_playerList_codec);
            break;
          }
          case 64: {
            DurationMs = input.ReadUInt64();
            break;
          }
          case 72: {
            Stage = (global::Weedwacker.Server.Proto.InBattleMechanicusStageType) input.ReadEnum();
            break;
          }
          case 80: {
            MaxEscapeMonsterNum = input.ReadUInt32();
            break;
          }
          case 90: {
            historyCardList_.AddEntriesFrom(input, _repeated_historyCardList_codec);
            break;
          }
          case 96: {
            TotalRound = input.ReadUInt32();
            break;
          }
          case 104: {
            WaitSeconds = input.ReadUInt32();
            break;
          }
          case 114: {
            monsterList_.AddEntriesFrom(input, _repeated_monsterList_codec);
            break;
          }
          case 122: {
            pickCardList_.AddEntriesFrom(input, _repeated_pickCardList_codec);
            break;
          }
          case 922:
          case 920: {
            exitList_.AddEntriesFrom(input, _repeated_exitList_codec);
            break;
          }
          case 3282:
          case 3280: {
            entranceList_.AddEntriesFrom(input, _repeated_entranceList_codec);
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
            WaitBeginTimeUs = input.ReadUInt64();
            break;
          }
          case 16: {
            BeginTimeMs = input.ReadUInt64();
            break;
          }
          case 24: {
            Round = input.ReadUInt32();
            break;
          }
          case 32: {
            BuildingStageDuration = input.ReadUInt32();
            break;
          }
          case 40: {
            LeftMonster = input.ReadUInt32();
            break;
          }
          case 48: {
            EscapedMonsterNum = input.ReadUInt32();
            break;
          }
          case 58: {
            playerList_.AddEntriesFrom(ref input, _repeated_playerList_codec);
            break;
          }
          case 64: {
            DurationMs = input.ReadUInt64();
            break;
          }
          case 72: {
            Stage = (global::Weedwacker.Server.Proto.InBattleMechanicusStageType) input.ReadEnum();
            break;
          }
          case 80: {
            MaxEscapeMonsterNum = input.ReadUInt32();
            break;
          }
          case 90: {
            historyCardList_.AddEntriesFrom(ref input, _repeated_historyCardList_codec);
            break;
          }
          case 96: {
            TotalRound = input.ReadUInt32();
            break;
          }
          case 104: {
            WaitSeconds = input.ReadUInt32();
            break;
          }
          case 114: {
            monsterList_.AddEntriesFrom(ref input, _repeated_monsterList_codec);
            break;
          }
          case 122: {
            pickCardList_.AddEntriesFrom(ref input, _repeated_pickCardList_codec);
            break;
          }
          case 922:
          case 920: {
            exitList_.AddEntriesFrom(ref input, _repeated_exitList_codec);
            break;
          }
          case 3282:
          case 3280: {
            entranceList_.AddEntriesFrom(ref input, _repeated_entranceList_codec);
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