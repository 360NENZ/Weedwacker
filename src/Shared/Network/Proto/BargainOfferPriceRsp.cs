// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BargainOfferPriceRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BargainOfferPriceRsp.proto</summary>
  public static partial class BargainOfferPriceRspReflection {

    #region Descriptor
    /// <summary>File descriptor for BargainOfferPriceRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BargainOfferPriceRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpCYXJnYWluT2ZmZXJQcmljZVJzcC5wcm90bxoXQmFyZ2FpblJlc3VsdFR5",
            "cGUucHJvdG8iewoUQmFyZ2Fpbk9mZmVyUHJpY2VSc3ASDwoHcmV0Y29kZRgF",
            "IAEoBRIUCgxyZXN1bHRfcGFyYW0YDSABKA0SKgoOYmFyZ2Fpbl9yZXN1bHQY",
            "DiABKA4yEi5CYXJnYWluUmVzdWx0VHlwZRIQCghjdXJfbW9vZBgGIAEoBUIi",
            "qgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.BargainResultTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BargainOfferPriceRsp), global::Weedwacker.Shared.Network.Proto.BargainOfferPriceRsp.Parser, new[]{ "Retcode", "ResultParam", "BargainResult", "CurMood" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 427
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class BargainOfferPriceRsp : pb::IMessage<BargainOfferPriceRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BargainOfferPriceRsp> _parser = new pb::MessageParser<BargainOfferPriceRsp>(() => new BargainOfferPriceRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BargainOfferPriceRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BargainOfferPriceRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BargainOfferPriceRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BargainOfferPriceRsp(BargainOfferPriceRsp other) : this() {
      retcode_ = other.retcode_;
      resultParam_ = other.resultParam_;
      bargainResult_ = other.bargainResult_;
      curMood_ = other.curMood_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BargainOfferPriceRsp Clone() {
      return new BargainOfferPriceRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 5;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "result_param" field.</summary>
    public const int ResultParamFieldNumber = 13;
    private uint resultParam_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ResultParam {
      get { return resultParam_; }
      set {
        resultParam_ = value;
      }
    }

    /// <summary>Field number for the "bargain_result" field.</summary>
    public const int BargainResultFieldNumber = 14;
    private global::Weedwacker.Shared.Network.Proto.BargainResultType bargainResult_ = global::Weedwacker.Shared.Network.Proto.BargainResultType.CompleteSucc;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.BargainResultType BargainResult {
      get { return bargainResult_; }
      set {
        bargainResult_ = value;
      }
    }

    /// <summary>Field number for the "cur_mood" field.</summary>
    public const int CurMoodFieldNumber = 6;
    private int curMood_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CurMood {
      get { return curMood_; }
      set {
        curMood_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BargainOfferPriceRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BargainOfferPriceRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (ResultParam != other.ResultParam) return false;
      if (BargainResult != other.BargainResult) return false;
      if (CurMood != other.CurMood) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (ResultParam != 0) hash ^= ResultParam.GetHashCode();
      if (BargainResult != global::Weedwacker.Shared.Network.Proto.BargainResultType.CompleteSucc) hash ^= BargainResult.GetHashCode();
      if (CurMood != 0) hash ^= CurMood.GetHashCode();
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
        output.WriteRawTag(40);
        output.WriteInt32(Retcode);
      }
      if (CurMood != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(CurMood);
      }
      if (ResultParam != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ResultParam);
      }
      if (BargainResult != global::Weedwacker.Shared.Network.Proto.BargainResultType.CompleteSucc) {
        output.WriteRawTag(112);
        output.WriteEnum((int) BargainResult);
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
        output.WriteRawTag(40);
        output.WriteInt32(Retcode);
      }
      if (CurMood != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(CurMood);
      }
      if (ResultParam != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ResultParam);
      }
      if (BargainResult != global::Weedwacker.Shared.Network.Proto.BargainResultType.CompleteSucc) {
        output.WriteRawTag(112);
        output.WriteEnum((int) BargainResult);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (ResultParam != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ResultParam);
      }
      if (BargainResult != global::Weedwacker.Shared.Network.Proto.BargainResultType.CompleteSucc) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BargainResult);
      }
      if (CurMood != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CurMood);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BargainOfferPriceRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.ResultParam != 0) {
        ResultParam = other.ResultParam;
      }
      if (other.BargainResult != global::Weedwacker.Shared.Network.Proto.BargainResultType.CompleteSucc) {
        BargainResult = other.BargainResult;
      }
      if (other.CurMood != 0) {
        CurMood = other.CurMood;
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
          case 40: {
            Retcode = input.ReadInt32();
            break;
          }
          case 48: {
            CurMood = input.ReadInt32();
            break;
          }
          case 104: {
            ResultParam = input.ReadUInt32();
            break;
          }
          case 112: {
            BargainResult = (global::Weedwacker.Shared.Network.Proto.BargainResultType) input.ReadEnum();
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
          case 40: {
            Retcode = input.ReadInt32();
            break;
          }
          case 48: {
            CurMood = input.ReadInt32();
            break;
          }
          case 104: {
            ResultParam = input.ReadUInt32();
            break;
          }
          case 112: {
            BargainResult = (global::Weedwacker.Shared.Network.Proto.BargainResultType) input.ReadEnum();
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
