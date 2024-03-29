// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CityReputationRequestInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CityReputationRequestInfo.proto</summary>
  public static partial class CityReputationRequestInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for CityReputationRequestInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CityReputationRequestInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9DaXR5UmVwdXRhdGlvblJlcXVlc3RJbmZvLnByb3RvIr0BChlDaXR5UmVw",
            "dXRhdGlvblJlcXVlc3RJbmZvEg8KB2lzX29wZW4YAiABKAgSQQoRcmVxdWVz",
            "dF9pbmZvX2xpc3QYASADKAsyJi5DaXR5UmVwdXRhdGlvblJlcXVlc3RJbmZv",
            "LlJlcXVlc3RJbmZvGkwKC1JlcXVlc3RJbmZvEhIKCnJlcXVlc3RfaWQYAyAB",
            "KA0SEAoIcXVlc3RfaWQYCSABKA0SFwoPaXNfdGFrZW5fcmV3YXJkGAYgASgI",
            "QiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CityReputationRequestInfo), global::Weedwacker.Shared.Network.Proto.CityReputationRequestInfo.Parser, new[]{ "IsOpen", "RequestInfoList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CityReputationRequestInfo.Types.RequestInfo), global::Weedwacker.Shared.Network.Proto.CityReputationRequestInfo.Types.RequestInfo.Parser, new[]{ "RequestId", "QuestId", "IsTakenReward" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CityReputationRequestInfo : pb::IMessage<CityReputationRequestInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CityReputationRequestInfo> _parser = new pb::MessageParser<CityReputationRequestInfo>(() => new CityReputationRequestInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CityReputationRequestInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CityReputationRequestInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CityReputationRequestInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CityReputationRequestInfo(CityReputationRequestInfo other) : this() {
      isOpen_ = other.isOpen_;
      requestInfoList_ = other.requestInfoList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CityReputationRequestInfo Clone() {
      return new CityReputationRequestInfo(this);
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 2;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "request_info_list" field.</summary>
    public const int RequestInfoListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.CityReputationRequestInfo.Types.RequestInfo> _repeated_requestInfoList_codec
        = pb::FieldCodec.ForMessage(10, global::Weedwacker.Shared.Network.Proto.CityReputationRequestInfo.Types.RequestInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CityReputationRequestInfo.Types.RequestInfo> requestInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CityReputationRequestInfo.Types.RequestInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CityReputationRequestInfo.Types.RequestInfo> RequestInfoList {
      get { return requestInfoList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CityReputationRequestInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CityReputationRequestInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsOpen != other.IsOpen) return false;
      if(!requestInfoList_.Equals(other.requestInfoList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      hash ^= requestInfoList_.GetHashCode();
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
      requestInfoList_.WriteTo(output, _repeated_requestInfoList_codec);
      if (IsOpen != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsOpen);
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
      requestInfoList_.WriteTo(ref output, _repeated_requestInfoList_codec);
      if (IsOpen != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsOpen);
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
      if (IsOpen != false) {
        size += 1 + 1;
      }
      size += requestInfoList_.CalculateSize(_repeated_requestInfoList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CityReputationRequestInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      requestInfoList_.Add(other.requestInfoList_);
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
            requestInfoList_.AddEntriesFrom(input, _repeated_requestInfoList_codec);
            break;
          }
          case 16: {
            IsOpen = input.ReadBool();
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
            requestInfoList_.AddEntriesFrom(ref input, _repeated_requestInfoList_codec);
            break;
          }
          case 16: {
            IsOpen = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CityReputationRequestInfo message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public sealed partial class RequestInfo : pb::IMessage<RequestInfo>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<RequestInfo> _parser = new pb::MessageParser<RequestInfo>(() => new RequestInfo());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<RequestInfo> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Weedwacker.Shared.Network.Proto.CityReputationRequestInfo.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public RequestInfo() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public RequestInfo(RequestInfo other) : this() {
          requestId_ = other.requestId_;
          questId_ = other.questId_;
          isTakenReward_ = other.isTakenReward_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public RequestInfo Clone() {
          return new RequestInfo(this);
        }

        /// <summary>Field number for the "request_id" field.</summary>
        public const int RequestIdFieldNumber = 3;
        private uint requestId_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public uint RequestId {
          get { return requestId_; }
          set {
            requestId_ = value;
          }
        }

        /// <summary>Field number for the "quest_id" field.</summary>
        public const int QuestIdFieldNumber = 9;
        private uint questId_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public uint QuestId {
          get { return questId_; }
          set {
            questId_ = value;
          }
        }

        /// <summary>Field number for the "is_taken_reward" field.</summary>
        public const int IsTakenRewardFieldNumber = 6;
        private bool isTakenReward_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool IsTakenReward {
          get { return isTakenReward_; }
          set {
            isTakenReward_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as RequestInfo);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(RequestInfo other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (RequestId != other.RequestId) return false;
          if (QuestId != other.QuestId) return false;
          if (IsTakenReward != other.IsTakenReward) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (RequestId != 0) hash ^= RequestId.GetHashCode();
          if (QuestId != 0) hash ^= QuestId.GetHashCode();
          if (IsTakenReward != false) hash ^= IsTakenReward.GetHashCode();
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
          if (RequestId != 0) {
            output.WriteRawTag(24);
            output.WriteUInt32(RequestId);
          }
          if (IsTakenReward != false) {
            output.WriteRawTag(48);
            output.WriteBool(IsTakenReward);
          }
          if (QuestId != 0) {
            output.WriteRawTag(72);
            output.WriteUInt32(QuestId);
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
          if (RequestId != 0) {
            output.WriteRawTag(24);
            output.WriteUInt32(RequestId);
          }
          if (IsTakenReward != false) {
            output.WriteRawTag(48);
            output.WriteBool(IsTakenReward);
          }
          if (QuestId != 0) {
            output.WriteRawTag(72);
            output.WriteUInt32(QuestId);
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
          if (RequestId != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RequestId);
          }
          if (QuestId != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QuestId);
          }
          if (IsTakenReward != false) {
            size += 1 + 1;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(RequestInfo other) {
          if (other == null) {
            return;
          }
          if (other.RequestId != 0) {
            RequestId = other.RequestId;
          }
          if (other.QuestId != 0) {
            QuestId = other.QuestId;
          }
          if (other.IsTakenReward != false) {
            IsTakenReward = other.IsTakenReward;
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
              case 24: {
                RequestId = input.ReadUInt32();
                break;
              }
              case 48: {
                IsTakenReward = input.ReadBool();
                break;
              }
              case 72: {
                QuestId = input.ReadUInt32();
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
              case 24: {
                RequestId = input.ReadUInt32();
                break;
              }
              case 48: {
                IsTakenReward = input.ReadBool();
                break;
              }
              case 72: {
                QuestId = input.ReadUInt32();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
