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

namespace Nebula.Meta
{

  public partial class SignInFTServiceReq : TBase
  {
    private global::Nebula.Meta.FTServiceType _type;
    private List<global::Nebula.Meta.FTClient> _clients;

    /// <summary>
    /// 
    /// <seealso cref="global::Nebula.Meta.FTServiceType"/>
    /// </summary>
    public global::Nebula.Meta.FTServiceType Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    public List<global::Nebula.Meta.FTClient> Clients
    {
      get
      {
        return _clients;
      }
      set
      {
        __isset.clients = true;
        this._clients = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool type;
      public bool clients;
    }

    public SignInFTServiceReq()
    {
    }

    public SignInFTServiceReq DeepCopy()
    {
      var tmp964 = new SignInFTServiceReq();
      if(__isset.type)
      {
        tmp964.Type = this.Type;
      }
      tmp964.__isset.type = this.__isset.type;
      if((Clients != null) && __isset.clients)
      {
        tmp964.Clients = this.Clients.DeepCopy();
      }
      tmp964.__isset.clients = this.__isset.clients;
      return tmp964;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
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
              if (field.Type == TType.I32)
              {
                Type = (global::Nebula.Meta.FTServiceType)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.List)
              {
                {
                  TList _list965 = await iprot.ReadListBeginAsync(cancellationToken);
                  Clients = new List<global::Nebula.Meta.FTClient>(_list965.Count);
                  for(int _i966 = 0; _i966 < _list965.Count; ++_i966)
                  {
                    global::Nebula.Meta.FTClient _elem967;
                    _elem967 = new global::Nebula.Meta.FTClient();
                    await _elem967.ReadAsync(iprot, cancellationToken);
                    Clients.Add(_elem967);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
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
        var tmp968 = new TStruct("SignInFTServiceReq");
        await oprot.WriteStructBeginAsync(tmp968, cancellationToken);
        var tmp969 = new TField();
        if(__isset.type)
        {
          tmp969.Name = "type";
          tmp969.Type = TType.I32;
          tmp969.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp969, cancellationToken);
          await oprot.WriteI32Async((int)Type, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Clients != null) && __isset.clients)
        {
          tmp969.Name = "clients";
          tmp969.Type = TType.List;
          tmp969.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp969, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Clients.Count), cancellationToken);
            foreach (global::Nebula.Meta.FTClient _iter970 in Clients)
            {
              await _iter970.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
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
      if (!(that is SignInFTServiceReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.type == other.__isset.type) && ((!__isset.type) || (System.Object.Equals(Type, other.Type))))
        && ((__isset.clients == other.__isset.clients) && ((!__isset.clients) || (TCollections.Equals(Clients, other.Clients))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.type)
        {
          hashcode = (hashcode * 397) + Type.GetHashCode();
        }
        if((Clients != null) && __isset.clients)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Clients);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp971 = new StringBuilder("SignInFTServiceReq(");
      int tmp972 = 0;
      if(__isset.type)
      {
        if(0 < tmp972++) { tmp971.Append(", "); }
        tmp971.Append("Type: ");
        Type.ToString(tmp971);
      }
      if((Clients != null) && __isset.clients)
      {
        if(0 < tmp972++) { tmp971.Append(", "); }
        tmp971.Append("Clients: ");
        Clients.ToString(tmp971);
      }
      tmp971.Append(')');
      return tmp971.ToString();
    }
  }

}
