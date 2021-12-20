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

namespace Nebula.Common
{

  public partial class Vertex : TBase
  {
    private global::Nebula.Common.@Value _vid;
    private List<global::Nebula.Common.Tag> _tags;

    public global::Nebula.Common.@Value Vid
    {
      get
      {
        return _vid;
      }
      set
      {
        __isset.vid = true;
        this._vid = value;
      }
    }

    public List<global::Nebula.Common.Tag> Tags
    {
      get
      {
        return _tags;
      }
      set
      {
        __isset.tags = true;
        this._tags = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool vid;
      public bool tags;
    }

    public Vertex()
    {
    }

    public Vertex DeepCopy()
    {
      var tmp122 = new Vertex();
      if((Vid != null) && __isset.vid)
      {
        tmp122.Vid = (global::Nebula.Common.@Value)this.Vid.DeepCopy();
      }
      tmp122.__isset.vid = this.__isset.vid;
      if((Tags != null) && __isset.tags)
      {
        tmp122.Tags = this.Tags.DeepCopy();
      }
      tmp122.__isset.tags = this.__isset.tags;
      return tmp122;
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
              if (field.Type == TType.Struct)
              {
                Vid = new global::Nebula.Common.@Value();
                await Vid.ReadAsync(iprot, cancellationToken);
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
                  TList _list123 = await iprot.ReadListBeginAsync(cancellationToken);
                  Tags = new List<global::Nebula.Common.Tag>(_list123.Count);
                  for(int _i124 = 0; _i124 < _list123.Count; ++_i124)
                  {
                    global::Nebula.Common.Tag _elem125;
                    _elem125 = new global::Nebula.Common.Tag();
                    await _elem125.ReadAsync(iprot, cancellationToken);
                    Tags.Add(_elem125);
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
        var tmp126 = new TStruct("Vertex");
        await oprot.WriteStructBeginAsync(tmp126, cancellationToken);
        var tmp127 = new TField();
        if((Vid != null) && __isset.vid)
        {
          tmp127.Name = "vid";
          tmp127.Type = TType.Struct;
          tmp127.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp127, cancellationToken);
          await Vid.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Tags != null) && __isset.tags)
        {
          tmp127.Name = "tags";
          tmp127.Type = TType.List;
          tmp127.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp127, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Tags.Count), cancellationToken);
            foreach (global::Nebula.Common.Tag _iter128 in Tags)
            {
              await _iter128.WriteAsync(oprot, cancellationToken);
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
      if (!(that is Vertex other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.vid == other.__isset.vid) && ((!__isset.vid) || (System.Object.Equals(Vid, other.Vid))))
        && ((__isset.tags == other.__isset.tags) && ((!__isset.tags) || (TCollections.Equals(Tags, other.Tags))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Vid != null) && __isset.vid)
        {
          hashcode = (hashcode * 397) + Vid.GetHashCode();
        }
        if((Tags != null) && __isset.tags)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Tags);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp129 = new StringBuilder("Vertex(");
      int tmp130 = 0;
      if((Vid != null) && __isset.vid)
      {
        if(0 < tmp130++) { tmp129.Append(", "); }
        tmp129.Append("Vid: ");
        Vid.ToString(tmp129);
      }
      if((Tags != null) && __isset.tags)
      {
        if(0 < tmp130++) { tmp129.Append(", "); }
        tmp129.Append("Tags: ");
        Tags.ToString(tmp129);
      }
      tmp129.Append(')');
      return tmp129.ToString();
    }
  }

}
