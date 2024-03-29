// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PrivateChatNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PrivateChatNotify.proto</summary>
  public static partial class PrivateChatNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PrivateChatNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PrivateChatNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQcml2YXRlQ2hhdE5vdGlmeS5wcm90bxoOQ2hhdEluZm8ucHJvdG8iMQoR",
            "UHJpdmF0ZUNoYXROb3RpZnkSHAoJY2hhdF9pbmZvGAcgASgLMgkuQ2hhdElu",
            "Zm9CIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ChatInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PrivateChatNotify), global::Weedwacker.Shared.Network.Proto.PrivateChatNotify.Parser, new[]{ "ChatInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4962
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class PrivateChatNotify : pb::IMessage<PrivateChatNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PrivateChatNotify> _parser = new pb::MessageParser<PrivateChatNotify>(() => new PrivateChatNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PrivateChatNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PrivateChatNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PrivateChatNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PrivateChatNotify(PrivateChatNotify other) : this() {
      chatInfo_ = other.chatInfo_ != null ? other.chatInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PrivateChatNotify Clone() {
      return new PrivateChatNotify(this);
    }

    /// <summary>Field number for the "chat_info" field.</summary>
    public const int ChatInfoFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.ChatInfo chatInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ChatInfo ChatInfo {
      get { return chatInfo_; }
      set {
        chatInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PrivateChatNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PrivateChatNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ChatInfo, other.ChatInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (chatInfo_ != null) hash ^= ChatInfo.GetHashCode();
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
      if (chatInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ChatInfo);
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
      if (chatInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ChatInfo);
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
      if (chatInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChatInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PrivateChatNotify other) {
      if (other == null) {
        return;
      }
      if (other.chatInfo_ != null) {
        if (chatInfo_ == null) {
          ChatInfo = new global::Weedwacker.Shared.Network.Proto.ChatInfo();
        }
        ChatInfo.MergeFrom(other.ChatInfo);
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
          case 58: {
            if (chatInfo_ == null) {
              ChatInfo = new global::Weedwacker.Shared.Network.Proto.ChatInfo();
            }
            input.ReadMessage(ChatInfo);
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
          case 58: {
            if (chatInfo_ == null) {
              ChatInfo = new global::Weedwacker.Shared.Network.Proto.ChatInfo();
            }
            input.ReadMessage(ChatInfo);
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
