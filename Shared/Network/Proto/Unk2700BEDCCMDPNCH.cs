// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_BEDCCMDPNCH.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_BEDCCMDPNCH.proto</summary>
  public static partial class Unk2700BEDCCMDPNCHReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_BEDCCMDPNCH.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700BEDCCMDPNCHReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0JFRENDTURQTkNILnByb3RvGhlVbmsyNzAwX0JLSEJLSElO",
            "QklBLnByb3RvIlQKE1VuazI3MDBfQkVEQ0NNRFBOQ0gSEgoKZ2FsbGVyeV9p",
            "ZBgOIAEoDRIpCgtzZXR0bGVfaW5mbxgPIAEoCzIULlVuazI3MDBfQktIQktI",
            "SU5CSUFCIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2700BKHBKHINBIAReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_BEDCCMDPNCH), global::Weedwacker.Shared.Network.Proto.Unk2700_BEDCCMDPNCH.Parser, new[]{ "GalleryId", "SettleInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8499
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk2700_BEDCCMDPNCH : pb::IMessage<Unk2700_BEDCCMDPNCH>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_BEDCCMDPNCH> _parser = new pb::MessageParser<Unk2700_BEDCCMDPNCH>(() => new Unk2700_BEDCCMDPNCH());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_BEDCCMDPNCH> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700BEDCCMDPNCHReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_BEDCCMDPNCH() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_BEDCCMDPNCH(Unk2700_BEDCCMDPNCH other) : this() {
      galleryId_ = other.galleryId_;
      settleInfo_ = other.settleInfo_ != null ? other.settleInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_BEDCCMDPNCH Clone() {
      return new Unk2700_BEDCCMDPNCH(this);
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 14;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    /// <summary>Field number for the "settle_info" field.</summary>
    public const int SettleInfoFieldNumber = 15;
    private global::Weedwacker.Shared.Network.Proto.Unk2700_BKHBKHINBIA settleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Unk2700_BKHBKHINBIA SettleInfo {
      get { return settleInfo_; }
      set {
        settleInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_BEDCCMDPNCH);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_BEDCCMDPNCH other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GalleryId != other.GalleryId) return false;
      if (!object.Equals(SettleInfo, other.SettleInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      if (settleInfo_ != null) hash ^= SettleInfo.GetHashCode();
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
      if (GalleryId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GalleryId);
      }
      if (settleInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(SettleInfo);
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
      if (GalleryId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GalleryId);
      }
      if (settleInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(SettleInfo);
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
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (settleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SettleInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_BEDCCMDPNCH other) {
      if (other == null) {
        return;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
      }
      if (other.settleInfo_ != null) {
        if (settleInfo_ == null) {
          SettleInfo = new global::Weedwacker.Shared.Network.Proto.Unk2700_BKHBKHINBIA();
        }
        SettleInfo.MergeFrom(other.SettleInfo);
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
          case 112: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 122: {
            if (settleInfo_ == null) {
              SettleInfo = new global::Weedwacker.Shared.Network.Proto.Unk2700_BKHBKHINBIA();
            }
            input.ReadMessage(SettleInfo);
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
          case 112: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 122: {
            if (settleInfo_ == null) {
              SettleInfo = new global::Weedwacker.Shared.Network.Proto.Unk2700_BKHBKHINBIA();
            }
            input.ReadMessage(SettleInfo);
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