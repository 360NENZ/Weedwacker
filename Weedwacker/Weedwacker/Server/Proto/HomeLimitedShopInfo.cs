// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeLimitedShopInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from HomeLimitedShopInfo.proto</summary>
  public static partial class HomeLimitedShopInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeLimitedShopInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeLimitedShopInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlIb21lTGltaXRlZFNob3BJbmZvLnByb3RvGgxWZWN0b3IucHJvdG8iqQEK",
            "E0hvbWVMaW1pdGVkU2hvcEluZm8SFwoPbmV4dF9jbG9zZV90aW1lGAkgASgH",
            "EhwKFG5leHRfZ3Vlc3Rfb3Blbl90aW1lGAsgASgHEhoKCWRqaW5uX3JvdBgH",
            "IAEoCzIHLlZlY3RvchILCgN1aWQYBCABKA0SFgoObmV4dF9vcGVuX3RpbWUY",
            "BiABKAcSGgoJZGppbm5fcG9zGAIgASgLMgcuVmVjdG9yQhqqAhdXZWVkd2Fj",
            "a2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.HomeLimitedShopInfo), global::Weedwacker.Server.Proto.HomeLimitedShopInfo.Parser, new[]{ "NextCloseTime", "NextGuestOpenTime", "DjinnRot", "Uid", "NextOpenTime", "DjinnPos" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeLimitedShopInfo : pb::IMessage<HomeLimitedShopInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeLimitedShopInfo> _parser = new pb::MessageParser<HomeLimitedShopInfo>(() => new HomeLimitedShopInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeLimitedShopInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.HomeLimitedShopInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopInfo(HomeLimitedShopInfo other) : this() {
      nextCloseTime_ = other.nextCloseTime_;
      nextGuestOpenTime_ = other.nextGuestOpenTime_;
      djinnRot_ = other.djinnRot_ != null ? other.djinnRot_.Clone() : null;
      uid_ = other.uid_;
      nextOpenTime_ = other.nextOpenTime_;
      djinnPos_ = other.djinnPos_ != null ? other.djinnPos_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopInfo Clone() {
      return new HomeLimitedShopInfo(this);
    }

    /// <summary>Field number for the "next_close_time" field.</summary>
    public const int NextCloseTimeFieldNumber = 9;
    private uint nextCloseTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextCloseTime {
      get { return nextCloseTime_; }
      set {
        nextCloseTime_ = value;
      }
    }

    /// <summary>Field number for the "next_guest_open_time" field.</summary>
    public const int NextGuestOpenTimeFieldNumber = 11;
    private uint nextGuestOpenTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextGuestOpenTime {
      get { return nextGuestOpenTime_; }
      set {
        nextGuestOpenTime_ = value;
      }
    }

    /// <summary>Field number for the "djinn_rot" field.</summary>
    public const int DjinnRotFieldNumber = 7;
    private global::Weedwacker.Server.Proto.Vector djinnRot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector DjinnRot {
      get { return djinnRot_; }
      set {
        djinnRot_ = value;
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 4;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "next_open_time" field.</summary>
    public const int NextOpenTimeFieldNumber = 6;
    private uint nextOpenTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextOpenTime {
      get { return nextOpenTime_; }
      set {
        nextOpenTime_ = value;
      }
    }

    /// <summary>Field number for the "djinn_pos" field.</summary>
    public const int DjinnPosFieldNumber = 2;
    private global::Weedwacker.Server.Proto.Vector djinnPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector DjinnPos {
      get { return djinnPos_; }
      set {
        djinnPos_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeLimitedShopInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeLimitedShopInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NextCloseTime != other.NextCloseTime) return false;
      if (NextGuestOpenTime != other.NextGuestOpenTime) return false;
      if (!object.Equals(DjinnRot, other.DjinnRot)) return false;
      if (Uid != other.Uid) return false;
      if (NextOpenTime != other.NextOpenTime) return false;
      if (!object.Equals(DjinnPos, other.DjinnPos)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NextCloseTime != 0) hash ^= NextCloseTime.GetHashCode();
      if (NextGuestOpenTime != 0) hash ^= NextGuestOpenTime.GetHashCode();
      if (djinnRot_ != null) hash ^= DjinnRot.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (NextOpenTime != 0) hash ^= NextOpenTime.GetHashCode();
      if (djinnPos_ != null) hash ^= DjinnPos.GetHashCode();
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
      if (djinnPos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DjinnPos);
      }
      if (Uid != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Uid);
      }
      if (NextOpenTime != 0) {
        output.WriteRawTag(53);
        output.WriteFixed32(NextOpenTime);
      }
      if (djinnRot_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(DjinnRot);
      }
      if (NextCloseTime != 0) {
        output.WriteRawTag(77);
        output.WriteFixed32(NextCloseTime);
      }
      if (NextGuestOpenTime != 0) {
        output.WriteRawTag(93);
        output.WriteFixed32(NextGuestOpenTime);
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
      if (djinnPos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DjinnPos);
      }
      if (Uid != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Uid);
      }
      if (NextOpenTime != 0) {
        output.WriteRawTag(53);
        output.WriteFixed32(NextOpenTime);
      }
      if (djinnRot_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(DjinnRot);
      }
      if (NextCloseTime != 0) {
        output.WriteRawTag(77);
        output.WriteFixed32(NextCloseTime);
      }
      if (NextGuestOpenTime != 0) {
        output.WriteRawTag(93);
        output.WriteFixed32(NextGuestOpenTime);
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
      if (NextCloseTime != 0) {
        size += 1 + 4;
      }
      if (NextGuestOpenTime != 0) {
        size += 1 + 4;
      }
      if (djinnRot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DjinnRot);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (NextOpenTime != 0) {
        size += 1 + 4;
      }
      if (djinnPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DjinnPos);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeLimitedShopInfo other) {
      if (other == null) {
        return;
      }
      if (other.NextCloseTime != 0) {
        NextCloseTime = other.NextCloseTime;
      }
      if (other.NextGuestOpenTime != 0) {
        NextGuestOpenTime = other.NextGuestOpenTime;
      }
      if (other.djinnRot_ != null) {
        if (djinnRot_ == null) {
          DjinnRot = new global::Weedwacker.Server.Proto.Vector();
        }
        DjinnRot.MergeFrom(other.DjinnRot);
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.NextOpenTime != 0) {
        NextOpenTime = other.NextOpenTime;
      }
      if (other.djinnPos_ != null) {
        if (djinnPos_ == null) {
          DjinnPos = new global::Weedwacker.Server.Proto.Vector();
        }
        DjinnPos.MergeFrom(other.DjinnPos);
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
          case 18: {
            if (djinnPos_ == null) {
              DjinnPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(DjinnPos);
            break;
          }
          case 32: {
            Uid = input.ReadUInt32();
            break;
          }
          case 53: {
            NextOpenTime = input.ReadFixed32();
            break;
          }
          case 58: {
            if (djinnRot_ == null) {
              DjinnRot = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(DjinnRot);
            break;
          }
          case 77: {
            NextCloseTime = input.ReadFixed32();
            break;
          }
          case 93: {
            NextGuestOpenTime = input.ReadFixed32();
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
          case 18: {
            if (djinnPos_ == null) {
              DjinnPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(DjinnPos);
            break;
          }
          case 32: {
            Uid = input.ReadUInt32();
            break;
          }
          case 53: {
            NextOpenTime = input.ReadFixed32();
            break;
          }
          case 58: {
            if (djinnRot_ == null) {
              DjinnRot = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(DjinnRot);
            break;
          }
          case 77: {
            NextCloseTime = input.ReadFixed32();
            break;
          }
          case 93: {
            NextGuestOpenTime = input.ReadFixed32();
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