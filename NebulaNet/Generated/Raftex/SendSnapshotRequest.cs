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

namespace Nebula.Raftex
{

  public partial class SendSnapshotRequest : TBase
  {
    private int _space;
    private int _part;
    private long _term;
    private long _committed_log_id;
    private long _committed_log_term;
    private string _leader_addr;
    private int _leader_port;
    private List<byte[]> _rows;
    private long _total_size;
    private long _total_count;
    private bool _done;

    public int Space
    {
      get
      {
        return _space;
      }
      set
      {
        __isset.space = true;
        this._space = value;
      }
    }

    public int Part
    {
      get
      {
        return _part;
      }
      set
      {
        __isset.part = true;
        this._part = value;
      }
    }

    public long Term
    {
      get
      {
        return _term;
      }
      set
      {
        __isset.term = true;
        this._term = value;
      }
    }

    public long Committed_log_id
    {
      get
      {
        return _committed_log_id;
      }
      set
      {
        __isset.committed_log_id = true;
        this._committed_log_id = value;
      }
    }

    public long Committed_log_term
    {
      get
      {
        return _committed_log_term;
      }
      set
      {
        __isset.committed_log_term = true;
        this._committed_log_term = value;
      }
    }

    public string Leader_addr
    {
      get
      {
        return _leader_addr;
      }
      set
      {
        __isset.leader_addr = true;
        this._leader_addr = value;
      }
    }

    public int Leader_port
    {
      get
      {
        return _leader_port;
      }
      set
      {
        __isset.leader_port = true;
        this._leader_port = value;
      }
    }

    public List<byte[]> Rows
    {
      get
      {
        return _rows;
      }
      set
      {
        __isset.rows = true;
        this._rows = value;
      }
    }

    public long Total_size
    {
      get
      {
        return _total_size;
      }
      set
      {
        __isset.total_size = true;
        this._total_size = value;
      }
    }

    public long Total_count
    {
      get
      {
        return _total_count;
      }
      set
      {
        __isset.total_count = true;
        this._total_count = value;
      }
    }

    public bool Done
    {
      get
      {
        return _done;
      }
      set
      {
        __isset.done = true;
        this._done = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool space;
      public bool part;
      public bool term;
      public bool committed_log_id;
      public bool committed_log_term;
      public bool leader_addr;
      public bool leader_port;
      public bool rows;
      public bool total_size;
      public bool total_count;
      public bool done;
    }

    public SendSnapshotRequest()
    {
    }

    public SendSnapshotRequest DeepCopy()
    {
      var tmp29 = new SendSnapshotRequest();
      if(__isset.space)
      {
        tmp29.Space = this.Space;
      }
      tmp29.__isset.space = this.__isset.space;
      if(__isset.part)
      {
        tmp29.Part = this.Part;
      }
      tmp29.__isset.part = this.__isset.part;
      if(__isset.term)
      {
        tmp29.Term = this.Term;
      }
      tmp29.__isset.term = this.__isset.term;
      if(__isset.committed_log_id)
      {
        tmp29.Committed_log_id = this.Committed_log_id;
      }
      tmp29.__isset.committed_log_id = this.__isset.committed_log_id;
      if(__isset.committed_log_term)
      {
        tmp29.Committed_log_term = this.Committed_log_term;
      }
      tmp29.__isset.committed_log_term = this.__isset.committed_log_term;
      if((Leader_addr != null) && __isset.leader_addr)
      {
        tmp29.Leader_addr = this.Leader_addr;
      }
      tmp29.__isset.leader_addr = this.__isset.leader_addr;
      if(__isset.leader_port)
      {
        tmp29.Leader_port = this.Leader_port;
      }
      tmp29.__isset.leader_port = this.__isset.leader_port;
      if((Rows != null) && __isset.rows)
      {
        tmp29.Rows = this.Rows.DeepCopy();
      }
      tmp29.__isset.rows = this.__isset.rows;
      if(__isset.total_size)
      {
        tmp29.Total_size = this.Total_size;
      }
      tmp29.__isset.total_size = this.__isset.total_size;
      if(__isset.total_count)
      {
        tmp29.Total_count = this.Total_count;
      }
      tmp29.__isset.total_count = this.__isset.total_count;
      if(__isset.done)
      {
        tmp29.Done = this.Done;
      }
      tmp29.__isset.done = this.__isset.done;
      return tmp29;
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
                Space = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I32)
              {
                Part = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                Term = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I64)
              {
                Committed_log_id = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I64)
              {
                Committed_log_term = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.String)
              {
                Leader_addr = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.I32)
              {
                Leader_port = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.List)
              {
                {
                  TList _list30 = await iprot.ReadListBeginAsync(cancellationToken);
                  Rows = new List<byte[]>(_list30.Count);
                  for(int _i31 = 0; _i31 < _list30.Count; ++_i31)
                  {
                    byte[] _elem32;
                    _elem32 = await iprot.ReadBinaryAsync(cancellationToken);
                    Rows.Add(_elem32);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 9:
              if (field.Type == TType.I64)
              {
                Total_size = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 10:
              if (field.Type == TType.I64)
              {
                Total_count = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 11:
              if (field.Type == TType.Bool)
              {
                Done = await iprot.ReadBoolAsync(cancellationToken);
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
        var tmp33 = new TStruct("SendSnapshotRequest");
        await oprot.WriteStructBeginAsync(tmp33, cancellationToken);
        var tmp34 = new TField();
        if(__isset.space)
        {
          tmp34.Name = "space";
          tmp34.Type = TType.I32;
          tmp34.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp34, cancellationToken);
          await oprot.WriteI32Async(Space, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.part)
        {
          tmp34.Name = "part";
          tmp34.Type = TType.I32;
          tmp34.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp34, cancellationToken);
          await oprot.WriteI32Async(Part, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.term)
        {
          tmp34.Name = "term";
          tmp34.Type = TType.I64;
          tmp34.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp34, cancellationToken);
          await oprot.WriteI64Async(Term, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.committed_log_id)
        {
          tmp34.Name = "committed_log_id";
          tmp34.Type = TType.I64;
          tmp34.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp34, cancellationToken);
          await oprot.WriteI64Async(Committed_log_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.committed_log_term)
        {
          tmp34.Name = "committed_log_term";
          tmp34.Type = TType.I64;
          tmp34.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp34, cancellationToken);
          await oprot.WriteI64Async(Committed_log_term, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Leader_addr != null) && __isset.leader_addr)
        {
          tmp34.Name = "leader_addr";
          tmp34.Type = TType.String;
          tmp34.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp34, cancellationToken);
          await oprot.WriteStringAsync(Leader_addr, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.leader_port)
        {
          tmp34.Name = "leader_port";
          tmp34.Type = TType.I32;
          tmp34.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp34, cancellationToken);
          await oprot.WriteI32Async(Leader_port, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Rows != null) && __isset.rows)
        {
          tmp34.Name = "rows";
          tmp34.Type = TType.List;
          tmp34.ID = 8;
          await oprot.WriteFieldBeginAsync(tmp34, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.String, Rows.Count), cancellationToken);
            foreach (byte[] _iter35 in Rows)
            {
              await oprot.WriteBinaryAsync(_iter35, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.total_size)
        {
          tmp34.Name = "total_size";
          tmp34.Type = TType.I64;
          tmp34.ID = 9;
          await oprot.WriteFieldBeginAsync(tmp34, cancellationToken);
          await oprot.WriteI64Async(Total_size, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.total_count)
        {
          tmp34.Name = "total_count";
          tmp34.Type = TType.I64;
          tmp34.ID = 10;
          await oprot.WriteFieldBeginAsync(tmp34, cancellationToken);
          await oprot.WriteI64Async(Total_count, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.done)
        {
          tmp34.Name = "done";
          tmp34.Type = TType.Bool;
          tmp34.ID = 11;
          await oprot.WriteFieldBeginAsync(tmp34, cancellationToken);
          await oprot.WriteBoolAsync(Done, cancellationToken);
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
      if (!(that is SendSnapshotRequest other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space == other.__isset.space) && ((!__isset.space) || (System.Object.Equals(Space, other.Space))))
        && ((__isset.part == other.__isset.part) && ((!__isset.part) || (System.Object.Equals(Part, other.Part))))
        && ((__isset.term == other.__isset.term) && ((!__isset.term) || (System.Object.Equals(Term, other.Term))))
        && ((__isset.committed_log_id == other.__isset.committed_log_id) && ((!__isset.committed_log_id) || (System.Object.Equals(Committed_log_id, other.Committed_log_id))))
        && ((__isset.committed_log_term == other.__isset.committed_log_term) && ((!__isset.committed_log_term) || (System.Object.Equals(Committed_log_term, other.Committed_log_term))))
        && ((__isset.leader_addr == other.__isset.leader_addr) && ((!__isset.leader_addr) || (System.Object.Equals(Leader_addr, other.Leader_addr))))
        && ((__isset.leader_port == other.__isset.leader_port) && ((!__isset.leader_port) || (System.Object.Equals(Leader_port, other.Leader_port))))
        && ((__isset.rows == other.__isset.rows) && ((!__isset.rows) || (TCollections.Equals(Rows, other.Rows))))
        && ((__isset.total_size == other.__isset.total_size) && ((!__isset.total_size) || (System.Object.Equals(Total_size, other.Total_size))))
        && ((__isset.total_count == other.__isset.total_count) && ((!__isset.total_count) || (System.Object.Equals(Total_count, other.Total_count))))
        && ((__isset.done == other.__isset.done) && ((!__isset.done) || (System.Object.Equals(Done, other.Done))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.space)
        {
          hashcode = (hashcode * 397) + Space.GetHashCode();
        }
        if(__isset.part)
        {
          hashcode = (hashcode * 397) + Part.GetHashCode();
        }
        if(__isset.term)
        {
          hashcode = (hashcode * 397) + Term.GetHashCode();
        }
        if(__isset.committed_log_id)
        {
          hashcode = (hashcode * 397) + Committed_log_id.GetHashCode();
        }
        if(__isset.committed_log_term)
        {
          hashcode = (hashcode * 397) + Committed_log_term.GetHashCode();
        }
        if((Leader_addr != null) && __isset.leader_addr)
        {
          hashcode = (hashcode * 397) + Leader_addr.GetHashCode();
        }
        if(__isset.leader_port)
        {
          hashcode = (hashcode * 397) + Leader_port.GetHashCode();
        }
        if((Rows != null) && __isset.rows)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Rows);
        }
        if(__isset.total_size)
        {
          hashcode = (hashcode * 397) + Total_size.GetHashCode();
        }
        if(__isset.total_count)
        {
          hashcode = (hashcode * 397) + Total_count.GetHashCode();
        }
        if(__isset.done)
        {
          hashcode = (hashcode * 397) + Done.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp36 = new StringBuilder("SendSnapshotRequest(");
      int tmp37 = 0;
      if(__isset.space)
      {
        if(0 < tmp37++) { tmp36.Append(", "); }
        tmp36.Append("Space: ");
        Space.ToString(tmp36);
      }
      if(__isset.part)
      {
        if(0 < tmp37++) { tmp36.Append(", "); }
        tmp36.Append("Part: ");
        Part.ToString(tmp36);
      }
      if(__isset.term)
      {
        if(0 < tmp37++) { tmp36.Append(", "); }
        tmp36.Append("Term: ");
        Term.ToString(tmp36);
      }
      if(__isset.committed_log_id)
      {
        if(0 < tmp37++) { tmp36.Append(", "); }
        tmp36.Append("Committed_log_id: ");
        Committed_log_id.ToString(tmp36);
      }
      if(__isset.committed_log_term)
      {
        if(0 < tmp37++) { tmp36.Append(", "); }
        tmp36.Append("Committed_log_term: ");
        Committed_log_term.ToString(tmp36);
      }
      if((Leader_addr != null) && __isset.leader_addr)
      {
        if(0 < tmp37++) { tmp36.Append(", "); }
        tmp36.Append("Leader_addr: ");
        Leader_addr.ToString(tmp36);
      }
      if(__isset.leader_port)
      {
        if(0 < tmp37++) { tmp36.Append(", "); }
        tmp36.Append("Leader_port: ");
        Leader_port.ToString(tmp36);
      }
      if((Rows != null) && __isset.rows)
      {
        if(0 < tmp37++) { tmp36.Append(", "); }
        tmp36.Append("Rows: ");
        Rows.ToString(tmp36);
      }
      if(__isset.total_size)
      {
        if(0 < tmp37++) { tmp36.Append(", "); }
        tmp36.Append("Total_size: ");
        Total_size.ToString(tmp36);
      }
      if(__isset.total_count)
      {
        if(0 < tmp37++) { tmp36.Append(", "); }
        tmp36.Append("Total_count: ");
        Total_count.ToString(tmp36);
      }
      if(__isset.done)
      {
        if(0 < tmp37++) { tmp36.Append(", "); }
        tmp36.Append("Done: ");
        Done.ToString(tmp36);
      }
      tmp36.Append(')');
      return tmp36.ToString();
    }
  }

}
