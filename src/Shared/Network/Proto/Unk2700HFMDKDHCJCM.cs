// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_HFMDKDHCJCM.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_HFMDKDHCJCM.proto</summary>
  public static partial class Unk2700HFMDKDHCJCMReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_HFMDKDHCJCM.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700HFMDKDHCJCMReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0hGTURLREhDSkNNLnByb3RvGgxWZWN0b3IucHJvdG8iOwoT",
            "VW5rMjcwMF9IRk1ES0RIQ0pDTRIkChNVbmsyNzAwX0NNT01ORk5HQ0dCGAEg",
            "ASgLMgcuVmVjdG9yQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_HFMDKDHCJCM), global::Weedwacker.Shared.Network.Proto.Unk2700_HFMDKDHCJCM.Parser, new[]{ "Unk2700CMOMNFNGCGB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk2700_HFMDKDHCJCM : pb::IMessage<Unk2700_HFMDKDHCJCM>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_HFMDKDHCJCM> _parser = new pb::MessageParser<Unk2700_HFMDKDHCJCM>(() => new Unk2700_HFMDKDHCJCM());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_HFMDKDHCJCM> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700HFMDKDHCJCMReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_HFMDKDHCJCM() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_HFMDKDHCJCM(Unk2700_HFMDKDHCJCM other) : this() {
      unk2700CMOMNFNGCGB_ = other.unk2700CMOMNFNGCGB_ != null ? other.unk2700CMOMNFNGCGB_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_HFMDKDHCJCM Clone() {
      return new Unk2700_HFMDKDHCJCM(this);
    }

    /// <summary>Field number for the "Unk2700_CMOMNFNGCGB" field.</summary>
    public const int Unk2700CMOMNFNGCGBFieldNumber = 1;
    private global::Weedwacker.Shared.Network.Proto.Vector unk2700CMOMNFNGCGB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Unk2700CMOMNFNGCGB {
      get { return unk2700CMOMNFNGCGB_; }
      set {
        unk2700CMOMNFNGCGB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_HFMDKDHCJCM);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_HFMDKDHCJCM other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Unk2700CMOMNFNGCGB, other.Unk2700CMOMNFNGCGB)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (unk2700CMOMNFNGCGB_ != null) hash ^= Unk2700CMOMNFNGCGB.GetHashCode();
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
      if (unk2700CMOMNFNGCGB_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Unk2700CMOMNFNGCGB);
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
      if (unk2700CMOMNFNGCGB_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Unk2700CMOMNFNGCGB);
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
      if (unk2700CMOMNFNGCGB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk2700CMOMNFNGCGB);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_HFMDKDHCJCM other) {
      if (other == null) {
        return;
      }
      if (other.unk2700CMOMNFNGCGB_ != null) {
        if (unk2700CMOMNFNGCGB_ == null) {
          Unk2700CMOMNFNGCGB = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Unk2700CMOMNFNGCGB.MergeFrom(other.Unk2700CMOMNFNGCGB);
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
          case 10: {
            if (unk2700CMOMNFNGCGB_ == null) {
              Unk2700CMOMNFNGCGB = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Unk2700CMOMNFNGCGB);
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
            if (unk2700CMOMNFNGCGB_ == null) {
              Unk2700CMOMNFNGCGB = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Unk2700CMOMNFNGCGB);
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
