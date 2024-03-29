// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WorldOwnerDailyTaskNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from WorldOwnerDailyTaskNotify.proto</summary>
  public static partial class WorldOwnerDailyTaskNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for WorldOwnerDailyTaskNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WorldOwnerDailyTaskNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Xb3JsZE93bmVyRGFpbHlUYXNrTm90aWZ5LnByb3RvGhNEYWlseVRhc2tJ",
            "bmZvLnByb3RvIlYKGVdvcmxkT3duZXJEYWlseVRhc2tOb3RpZnkSFgoOZmls",
            "dGVyX2NpdHlfaWQYAiABKA0SIQoJdGFza19saXN0GAEgAygLMg4uRGFpbHlU",
            "YXNrSW5mb0IiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.DailyTaskInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.WorldOwnerDailyTaskNotify), global::Weedwacker.Shared.Network.Proto.WorldOwnerDailyTaskNotify.Parser, new[]{ "FilterCityId", "TaskList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 102
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class WorldOwnerDailyTaskNotify : pb::IMessage<WorldOwnerDailyTaskNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WorldOwnerDailyTaskNotify> _parser = new pb::MessageParser<WorldOwnerDailyTaskNotify>(() => new WorldOwnerDailyTaskNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WorldOwnerDailyTaskNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.WorldOwnerDailyTaskNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldOwnerDailyTaskNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldOwnerDailyTaskNotify(WorldOwnerDailyTaskNotify other) : this() {
      filterCityId_ = other.filterCityId_;
      taskList_ = other.taskList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldOwnerDailyTaskNotify Clone() {
      return new WorldOwnerDailyTaskNotify(this);
    }

    /// <summary>Field number for the "filter_city_id" field.</summary>
    public const int FilterCityIdFieldNumber = 2;
    private uint filterCityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FilterCityId {
      get { return filterCityId_; }
      set {
        filterCityId_ = value;
      }
    }

    /// <summary>Field number for the "task_list" field.</summary>
    public const int TaskListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.DailyTaskInfo> _repeated_taskList_codec
        = pb::FieldCodec.ForMessage(10, global::Weedwacker.Shared.Network.Proto.DailyTaskInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.DailyTaskInfo> taskList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.DailyTaskInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.DailyTaskInfo> TaskList {
      get { return taskList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WorldOwnerDailyTaskNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WorldOwnerDailyTaskNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FilterCityId != other.FilterCityId) return false;
      if(!taskList_.Equals(other.taskList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FilterCityId != 0) hash ^= FilterCityId.GetHashCode();
      hash ^= taskList_.GetHashCode();
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
      taskList_.WriteTo(output, _repeated_taskList_codec);
      if (FilterCityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FilterCityId);
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
      taskList_.WriteTo(ref output, _repeated_taskList_codec);
      if (FilterCityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FilterCityId);
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
      if (FilterCityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FilterCityId);
      }
      size += taskList_.CalculateSize(_repeated_taskList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WorldOwnerDailyTaskNotify other) {
      if (other == null) {
        return;
      }
      if (other.FilterCityId != 0) {
        FilterCityId = other.FilterCityId;
      }
      taskList_.Add(other.taskList_);
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
          case 10: {
            taskList_.AddEntriesFrom(input, _repeated_taskList_codec);
            break;
          }
          case 16: {
            FilterCityId = input.ReadUInt32();
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
          case 10: {
            taskList_.AddEntriesFrom(ref input, _repeated_taskList_codec);
            break;
          }
          case 16: {
            FilterCityId = input.ReadUInt32();
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
