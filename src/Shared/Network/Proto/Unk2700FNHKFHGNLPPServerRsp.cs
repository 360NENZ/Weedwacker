// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_FNHKFHGNLPP_ServerRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_FNHKFHGNLPP_ServerRsp.proto</summary>
  public static partial class Unk2700FNHKFHGNLPPServerRspReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_FNHKFHGNLPP_ServerRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700FNHKFHGNLPPServerRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNVbmsyNzAwX0ZOSEtGSEdOTFBQX1NlcnZlclJzcC5wcm90bxoZVW5rMjcw",
            "MF9HSEhDQ0VIR0tMSC5wcm90byJjCh1VbmsyNzAwX0ZOSEtGSEdOTFBQX1Nl",
            "cnZlclJzcBIxChNVbmsyNzAwX0JDSUJFUE1GTEdOGAggAygLMhQuVW5rMjcw",
            "MF9HSEhDQ0VIR0tMSBIPCgdyZXRjb2RlGA4gASgFQiKqAh9XZWVkd2Fja2Vy",
            "LlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2700GHHCCEHGKLHReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_FNHKFHGNLPP_ServerRsp), global::Weedwacker.Shared.Network.Proto.Unk2700_FNHKFHGNLPP_ServerRsp.Parser, new[]{ "Unk2700BCIBEPMFLGN", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 6248
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk2700_FNHKFHGNLPP_ServerRsp : pb::IMessage<Unk2700_FNHKFHGNLPP_ServerRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_FNHKFHGNLPP_ServerRsp> _parser = new pb::MessageParser<Unk2700_FNHKFHGNLPP_ServerRsp>(() => new Unk2700_FNHKFHGNLPP_ServerRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_FNHKFHGNLPP_ServerRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700FNHKFHGNLPPServerRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_FNHKFHGNLPP_ServerRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_FNHKFHGNLPP_ServerRsp(Unk2700_FNHKFHGNLPP_ServerRsp other) : this() {
      unk2700BCIBEPMFLGN_ = other.unk2700BCIBEPMFLGN_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_FNHKFHGNLPP_ServerRsp Clone() {
      return new Unk2700_FNHKFHGNLPP_ServerRsp(this);
    }

    /// <summary>Field number for the "Unk2700_BCIBEPMFLGN" field.</summary>
    public const int Unk2700BCIBEPMFLGNFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.Unk2700_GHHCCEHGKLH> _repeated_unk2700BCIBEPMFLGN_codec
        = pb::FieldCodec.ForMessage(66, global::Weedwacker.Shared.Network.Proto.Unk2700_GHHCCEHGKLH.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_GHHCCEHGKLH> unk2700BCIBEPMFLGN_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_GHHCCEHGKLH>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_GHHCCEHGKLH> Unk2700BCIBEPMFLGN {
      get { return unk2700BCIBEPMFLGN_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
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
      return Equals(other as Unk2700_FNHKFHGNLPP_ServerRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_FNHKFHGNLPP_ServerRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk2700BCIBEPMFLGN_.Equals(other.unk2700BCIBEPMFLGN_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk2700BCIBEPMFLGN_.GetHashCode();
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
      unk2700BCIBEPMFLGN_.WriteTo(output, _repeated_unk2700BCIBEPMFLGN_codec);
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Retcode);
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
      unk2700BCIBEPMFLGN_.WriteTo(ref output, _repeated_unk2700BCIBEPMFLGN_codec);
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Retcode);
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
      size += unk2700BCIBEPMFLGN_.CalculateSize(_repeated_unk2700BCIBEPMFLGN_codec);
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
    public void MergeFrom(Unk2700_FNHKFHGNLPP_ServerRsp other) {
      if (other == null) {
        return;
      }
      unk2700BCIBEPMFLGN_.Add(other.unk2700BCIBEPMFLGN_);
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
          case 66: {
            unk2700BCIBEPMFLGN_.AddEntriesFrom(input, _repeated_unk2700BCIBEPMFLGN_codec);
            break;
          }
          case 112: {
            Retcode = input.ReadInt32();
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
          case 66: {
            unk2700BCIBEPMFLGN_.AddEntriesFrom(ref input, _repeated_unk2700BCIBEPMFLGN_codec);
            break;
          }
          case 112: {
            Retcode = input.ReadInt32();
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
