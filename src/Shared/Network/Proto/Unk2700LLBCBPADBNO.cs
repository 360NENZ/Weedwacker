// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_LLBCBPADBNO.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_LLBCBPADBNO.proto</summary>
  public static partial class Unk2700LLBCBPADBNOReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_LLBCBPADBNO.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700LLBCBPADBNOReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0xMQkNCUEFEQk5PLnByb3RvGhlVbmsyNzAwX0RJRUdKREVJ",
            "REtPLnByb3RvImwKE1VuazI3MDBfTExCQ0JQQURCTk8SKgoMZXhwbG9yZV9p",
            "bmZvGAwgASgLMhQuVW5rMjcwMF9ESUVHSkRFSURLTxIpCgtiYXR0bGVfaW5m",
            "bxgEIAEoCzIULlVuazI3MDBfRElFR0pERUlES09CIqoCH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2700DIEGJDEIDKOReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_LLBCBPADBNO), global::Weedwacker.Shared.Network.Proto.Unk2700_LLBCBPADBNO.Parser, new[]{ "ExploreInfo", "BattleInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8154
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk2700_LLBCBPADBNO : pb::IMessage<Unk2700_LLBCBPADBNO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_LLBCBPADBNO> _parser = new pb::MessageParser<Unk2700_LLBCBPADBNO>(() => new Unk2700_LLBCBPADBNO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_LLBCBPADBNO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700LLBCBPADBNOReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_LLBCBPADBNO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_LLBCBPADBNO(Unk2700_LLBCBPADBNO other) : this() {
      exploreInfo_ = other.exploreInfo_ != null ? other.exploreInfo_.Clone() : null;
      battleInfo_ = other.battleInfo_ != null ? other.battleInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_LLBCBPADBNO Clone() {
      return new Unk2700_LLBCBPADBNO(this);
    }

    /// <summary>Field number for the "explore_info" field.</summary>
    public const int ExploreInfoFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.Unk2700_DIEGJDEIDKO exploreInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Unk2700_DIEGJDEIDKO ExploreInfo {
      get { return exploreInfo_; }
      set {
        exploreInfo_ = value;
      }
    }

    /// <summary>Field number for the "battle_info" field.</summary>
    public const int BattleInfoFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.Unk2700_DIEGJDEIDKO battleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Unk2700_DIEGJDEIDKO BattleInfo {
      get { return battleInfo_; }
      set {
        battleInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_LLBCBPADBNO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_LLBCBPADBNO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ExploreInfo, other.ExploreInfo)) return false;
      if (!object.Equals(BattleInfo, other.BattleInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (exploreInfo_ != null) hash ^= ExploreInfo.GetHashCode();
      if (battleInfo_ != null) hash ^= BattleInfo.GetHashCode();
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
      if (battleInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(BattleInfo);
      }
      if (exploreInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(ExploreInfo);
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
      if (battleInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(BattleInfo);
      }
      if (exploreInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(ExploreInfo);
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
      if (exploreInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExploreInfo);
      }
      if (battleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_LLBCBPADBNO other) {
      if (other == null) {
        return;
      }
      if (other.exploreInfo_ != null) {
        if (exploreInfo_ == null) {
          ExploreInfo = new global::Weedwacker.Shared.Network.Proto.Unk2700_DIEGJDEIDKO();
        }
        ExploreInfo.MergeFrom(other.ExploreInfo);
      }
      if (other.battleInfo_ != null) {
        if (battleInfo_ == null) {
          BattleInfo = new global::Weedwacker.Shared.Network.Proto.Unk2700_DIEGJDEIDKO();
        }
        BattleInfo.MergeFrom(other.BattleInfo);
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
          case 34: {
            if (battleInfo_ == null) {
              BattleInfo = new global::Weedwacker.Shared.Network.Proto.Unk2700_DIEGJDEIDKO();
            }
            input.ReadMessage(BattleInfo);
            break;
          }
          case 98: {
            if (exploreInfo_ == null) {
              ExploreInfo = new global::Weedwacker.Shared.Network.Proto.Unk2700_DIEGJDEIDKO();
            }
            input.ReadMessage(ExploreInfo);
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
          case 34: {
            if (battleInfo_ == null) {
              BattleInfo = new global::Weedwacker.Shared.Network.Proto.Unk2700_DIEGJDEIDKO();
            }
            input.ReadMessage(BattleInfo);
            break;
          }
          case 98: {
            if (exploreInfo_ == null) {
              ExploreInfo = new global::Weedwacker.Shared.Network.Proto.Unk2700_DIEGJDEIDKO();
            }
            input.ReadMessage(ExploreInfo);
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
