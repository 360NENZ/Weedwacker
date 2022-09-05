// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChannelerSlabOneofDungeon.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from ChannelerSlabOneofDungeon.proto</summary>
  public static partial class ChannelerSlabOneofDungeonReflection {

    #region Descriptor
    /// <summary>File descriptor for ChannelerSlabOneofDungeon.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChannelerSlabOneofDungeonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9DaGFubmVsZXJTbGFiT25lb2ZEdW5nZW9uLnByb3RvIlMKGUNoYW5uZWxl",
            "clNsYWJPbmVvZkR1bmdlb24SDwoHaXNfZG9uZRgIIAEoCBISCgpkdW5nZW9u",
            "X2lkGAwgASgNEhEKCXJld2FyZF9pZBgNIAEoDUIaqgIXV2VlZHdhY2tlci5T",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.ChannelerSlabOneofDungeon), global::Weedwacker.Server.Proto.ChannelerSlabOneofDungeon.Parser, new[]{ "IsDone", "DungeonId", "RewardId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChannelerSlabOneofDungeon : pb::IMessage<ChannelerSlabOneofDungeon>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChannelerSlabOneofDungeon> _parser = new pb::MessageParser<ChannelerSlabOneofDungeon>(() => new ChannelerSlabOneofDungeon());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChannelerSlabOneofDungeon> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.ChannelerSlabOneofDungeonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabOneofDungeon() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabOneofDungeon(ChannelerSlabOneofDungeon other) : this() {
      isDone_ = other.isDone_;
      dungeonId_ = other.dungeonId_;
      rewardId_ = other.rewardId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabOneofDungeon Clone() {
      return new ChannelerSlabOneofDungeon(this);
    }

    /// <summary>Field number for the "is_done" field.</summary>
    public const int IsDoneFieldNumber = 8;
    private bool isDone_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsDone {
      get { return isDone_; }
      set {
        isDone_ = value;
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

    /// <summary>Field number for the "reward_id" field.</summary>
    public const int RewardIdFieldNumber = 13;
    private uint rewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RewardId {
      get { return rewardId_; }
      set {
        rewardId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChannelerSlabOneofDungeon);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChannelerSlabOneofDungeon other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsDone != other.IsDone) return false;
      if (DungeonId != other.DungeonId) return false;
      if (RewardId != other.RewardId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsDone != false) hash ^= IsDone.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      if (RewardId != 0) hash ^= RewardId.GetHashCode();
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
      if (IsDone != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsDone);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DungeonId);
      }
      if (RewardId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(RewardId);
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
      if (IsDone != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsDone);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DungeonId);
      }
      if (RewardId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(RewardId);
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
      if (IsDone != false) {
        size += 1 + 1;
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (RewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RewardId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChannelerSlabOneofDungeon other) {
      if (other == null) {
        return;
      }
      if (other.IsDone != false) {
        IsDone = other.IsDone;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      if (other.RewardId != 0) {
        RewardId = other.RewardId;
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
          case 64: {
            IsDone = input.ReadBool();
            break;
          }
          case 96: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 104: {
            RewardId = input.ReadUInt32();
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
          case 64: {
            IsDone = input.ReadBool();
            break;
          }
          case 96: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 104: {
            RewardId = input.ReadUInt32();
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