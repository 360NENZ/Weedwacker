// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetAuthkeyRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GetAuthkeyRsp.proto</summary>
  public static partial class GetAuthkeyRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetAuthkeyRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetAuthkeyRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNHZXRBdXRoa2V5UnNwLnByb3RvIn8KDUdldEF1dGhrZXlSc3ASEgoKYXV0",
            "aF9hcHBpZBgEIAEoCRIRCglzaWduX3R5cGUYDyABKA0SDwoHcmV0Y29kZRgG",
            "IAEoBRITCgthdXRoa2V5X3ZlchgJIAEoDRIQCghnYW1lX2JpehgLIAEoCRIP",
            "CgdhdXRoa2V5GAMgASgJQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3Jr",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GetAuthkeyRsp), global::Weedwacker.Shared.Network.Proto.GetAuthkeyRsp.Parser, new[]{ "AuthAppid", "SignType", "Retcode", "AuthkeyVer", "GameBiz", "Authkey" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1473
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class GetAuthkeyRsp : pb::IMessage<GetAuthkeyRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAuthkeyRsp> _parser = new pb::MessageParser<GetAuthkeyRsp>(() => new GetAuthkeyRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAuthkeyRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GetAuthkeyRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAuthkeyRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAuthkeyRsp(GetAuthkeyRsp other) : this() {
      authAppid_ = other.authAppid_;
      signType_ = other.signType_;
      retcode_ = other.retcode_;
      authkeyVer_ = other.authkeyVer_;
      gameBiz_ = other.gameBiz_;
      authkey_ = other.authkey_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAuthkeyRsp Clone() {
      return new GetAuthkeyRsp(this);
    }

    /// <summary>Field number for the "auth_appid" field.</summary>
    public const int AuthAppidFieldNumber = 4;
    private string authAppid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AuthAppid {
      get { return authAppid_; }
      set {
        authAppid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sign_type" field.</summary>
    public const int SignTypeFieldNumber = 15;
    private uint signType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SignType {
      get { return signType_; }
      set {
        signType_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "authkey_ver" field.</summary>
    public const int AuthkeyVerFieldNumber = 9;
    private uint authkeyVer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AuthkeyVer {
      get { return authkeyVer_; }
      set {
        authkeyVer_ = value;
      }
    }

    /// <summary>Field number for the "game_biz" field.</summary>
    public const int GameBizFieldNumber = 11;
    private string gameBiz_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GameBiz {
      get { return gameBiz_; }
      set {
        gameBiz_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "authkey" field.</summary>
    public const int AuthkeyFieldNumber = 3;
    private string authkey_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Authkey {
      get { return authkey_; }
      set {
        authkey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetAuthkeyRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAuthkeyRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AuthAppid != other.AuthAppid) return false;
      if (SignType != other.SignType) return false;
      if (Retcode != other.Retcode) return false;
      if (AuthkeyVer != other.AuthkeyVer) return false;
      if (GameBiz != other.GameBiz) return false;
      if (Authkey != other.Authkey) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AuthAppid.Length != 0) hash ^= AuthAppid.GetHashCode();
      if (SignType != 0) hash ^= SignType.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (AuthkeyVer != 0) hash ^= AuthkeyVer.GetHashCode();
      if (GameBiz.Length != 0) hash ^= GameBiz.GetHashCode();
      if (Authkey.Length != 0) hash ^= Authkey.GetHashCode();
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
      if (Authkey.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Authkey);
      }
      if (AuthAppid.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AuthAppid);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Retcode);
      }
      if (AuthkeyVer != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(AuthkeyVer);
      }
      if (GameBiz.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(GameBiz);
      }
      if (SignType != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SignType);
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
      if (Authkey.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Authkey);
      }
      if (AuthAppid.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AuthAppid);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Retcode);
      }
      if (AuthkeyVer != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(AuthkeyVer);
      }
      if (GameBiz.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(GameBiz);
      }
      if (SignType != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SignType);
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
      if (AuthAppid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AuthAppid);
      }
      if (SignType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SignType);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (AuthkeyVer != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AuthkeyVer);
      }
      if (GameBiz.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GameBiz);
      }
      if (Authkey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Authkey);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetAuthkeyRsp other) {
      if (other == null) {
        return;
      }
      if (other.AuthAppid.Length != 0) {
        AuthAppid = other.AuthAppid;
      }
      if (other.SignType != 0) {
        SignType = other.SignType;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.AuthkeyVer != 0) {
        AuthkeyVer = other.AuthkeyVer;
      }
      if (other.GameBiz.Length != 0) {
        GameBiz = other.GameBiz;
      }
      if (other.Authkey.Length != 0) {
        Authkey = other.Authkey;
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
          case 26: {
            Authkey = input.ReadString();
            break;
          }
          case 34: {
            AuthAppid = input.ReadString();
            break;
          }
          case 48: {
            Retcode = input.ReadInt32();
            break;
          }
          case 72: {
            AuthkeyVer = input.ReadUInt32();
            break;
          }
          case 90: {
            GameBiz = input.ReadString();
            break;
          }
          case 120: {
            SignType = input.ReadUInt32();
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
          case 26: {
            Authkey = input.ReadString();
            break;
          }
          case 34: {
            AuthAppid = input.ReadString();
            break;
          }
          case 48: {
            Retcode = input.ReadInt32();
            break;
          }
          case 72: {
            AuthkeyVer = input.ReadUInt32();
            break;
          }
          case 90: {
            GameBiz = input.ReadString();
            break;
          }
          case 120: {
            SignType = input.ReadUInt32();
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
