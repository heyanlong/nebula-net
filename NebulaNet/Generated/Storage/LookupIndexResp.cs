/**
 * Autogenerated by Thrift Compiler (0.15.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Nebula.Storage
{

  public partial class LookupIndexResp : TBase
  {
    private global::Nebula.Common.DataSet _data;

    public global::Nebula.Storage.ResponseCommon Result { get; set; }

    public global::Nebula.Common.DataSet Data
    {
      get
      {
        return _data;
      }
      set
      {
        __isset.data = true;
        this._data = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool data;
    }

    public LookupIndexResp()
    {
    }

    public LookupIndexResp(global::Nebula.Storage.ResponseCommon result) : this()
    {
      this.Result = result;
    }

    public LookupIndexResp DeepCopy()
    {
      var tmp319 = new LookupIndexResp();
      if((Result != null))
      {
        tmp319.Result = (global::Nebula.Storage.ResponseCommon)this.Result.DeepCopy();
      }
      if((Data != null) && __isset.data)
      {
        tmp319.Data = (global::Nebula.Common.DataSet)this.Data.DeepCopy();
      }
      tmp319.__isset.data = this.__isset.data;
      return tmp319;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_result = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.Struct)
              {
                Result = new global::Nebula.Storage.ResponseCommon();
                await Result.ReadAsync(iprot, cancellationToken);
                isset_result = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                Data = new global::Nebula.Common.DataSet();
                await Data.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_result)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp320 = new TStruct("LookupIndexResp");
        await oprot.WriteStructBeginAsync(tmp320, cancellationToken);
        var tmp321 = new TField();
        if((Result != null))
        {
          tmp321.Name = "result";
          tmp321.Type = TType.Struct;
          tmp321.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp321, cancellationToken);
          await Result.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Data != null) && __isset.data)
        {
          tmp321.Name = "data";
          tmp321.Type = TType.Struct;
          tmp321.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp321, cancellationToken);
          await Data.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is LookupIndexResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(Result, other.Result)
        && ((__isset.data == other.__isset.data) && ((!__isset.data) || (System.Object.Equals(Data, other.Data))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Result != null))
        {
          hashcode = (hashcode * 397) + Result.GetHashCode();
        }
        if((Data != null) && __isset.data)
        {
          hashcode = (hashcode * 397) + Data.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp322 = new StringBuilder("LookupIndexResp(");
      if((Result != null))
      {
        tmp322.Append(", Result: ");
        Result.ToString(tmp322);
      }
      if((Data != null) && __isset.data)
      {
        tmp322.Append(", Data: ");
        Data.ToString(tmp322);
      }
      tmp322.Append(')');
      return tmp322.ToString();
    }
  }

}
