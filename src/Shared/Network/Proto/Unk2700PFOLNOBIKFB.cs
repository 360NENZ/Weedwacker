// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_PFOLNOBIKFB.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_PFOLNOBIKFB.proto</summary>
  public static partial class Unk2700PFOLNOBIKFBReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_PFOLNOBIKFB.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700PFOLNOBIKFBReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX1BGT0xOT0JJS0ZCLnByb3RvImAKE1VuazI3MDBfUEZPTE5P",
            "QklLRkISGwoTVW5rMjcwMF9QSURQTk5PR0JKQhgEIAEoCBIbChNVbmsyNzAw",
            "X0RDR09JTElEUE5LGAMgASgIEg8KB3JldGNvZGUYASABKAVCIqoCH1dlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_PFOLNOBIKFB), global::Weedwacker.Shared.Network.Proto.Unk2700_PFOLNOBIKFB.Parser, new[]{ "Unk2700PIDPNNOGBJB", "Unk2700DCGOILIDPNK", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8833
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk2700_PFOLNOBIKFB : pb::IMessage<Unk2700_PFOLNOBIKFB>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_PFOLNOBIKFB> _parser = new pb::MessageParser<Unk2700_PFOLNOBIKFB>(() => new Unk2700_PFOLNOBIKFB());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_PFOLNOBIKFB> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700PFOLNOBIKFBReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_PFOLNOBIKFB() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_PFOLNOBIKFB(Unk2700_PFOLNOBIKFB other) : this() {
      unk2700PIDPNNOGBJB_ = other.unk2700PIDPNNOGBJB_;
      unk2700DCGOILIDPNK_ = other.unk2700DCGOILIDPNK_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_PFOLNOBIKFB Clone() {
      return new Unk2700_PFOLNOBIKFB(this);
    }

    /// <summary>Field number for the "Unk2700_PIDPNNOGBJB" field.</summary>
    public const int Unk2700PIDPNNOGBJBFieldNumber = 4;
    private bool unk2700PIDPNNOGBJB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700PIDPNNOGBJB {
      get { return unk2700PIDPNNOGBJB_; }
      set {
        unk2700PIDPNNOGBJB_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_DCGOILIDPNK" field.</summary>
    public const int Unk2700DCGOILIDPNKFieldNumber = 3;
    private bool unk2700DCGOILIDPNK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700DCGOILIDPNK {
      get { return unk2700DCGOILIDPNK_; }
      set {
        unk2700DCGOILIDPNK_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_PFOLNOBIKFB);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_PFOLNOBIKFB other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2700PIDPNNOGBJB != other.Unk2700PIDPNNOGBJB) return false;
      if (Unk2700DCGOILIDPNK != other.Unk2700DCGOILIDPNK) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2700PIDPNNOGBJB != false) hash ^= Unk2700PIDPNNOGBJB.GetHashCode();
      if (Unk2700DCGOILIDPNK != false) hash ^= Unk2700DCGOILIDPNK.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (Unk2700DCGOILIDPNK != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk2700DCGOILIDPNK);
      }
      if (Unk2700PIDPNNOGBJB != false) {
        output.WriteRawTag(32);
        output.WriteBool(Unk2700PIDPNNOGBJB);
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (Unk2700DCGOILIDPNK != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk2700DCGOILIDPNK);
      }
      if (Unk2700PIDPNNOGBJB != false) {
        output.WriteRawTag(32);
        output.WriteBool(Unk2700PIDPNNOGBJB);
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
      if (Unk2700PIDPNNOGBJB != false) {
        size += 1 + 1;
      }
      if (Unk2700DCGOILIDPNK != false) {
        size += 1 + 1;
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_PFOLNOBIKFB other) {
      if (other == null) {
        return;
      }
      if (other.Unk2700PIDPNNOGBJB != false) {
        Unk2700PIDPNNOGBJB = other.Unk2700PIDPNNOGBJB;
      }
      if (other.Unk2700DCGOILIDPNK != false) {
        Unk2700DCGOILIDPNK = other.Unk2700DCGOILIDPNK;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
            Retcode = input.ReadInt32();
            break;
          }
          case 24: {
            Unk2700DCGOILIDPNK = input.ReadBool();
            break;
          }
          case 32: {
            Unk2700PIDPNNOGBJB = input.ReadBool();
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
            Retcode = input.ReadInt32();
            break;
          }
          case 24: {
            Unk2700DCGOILIDPNK = input.ReadBool();
            break;
          }
          case 32: {
            Unk2700PIDPNNOGBJB = input.ReadBool();
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
