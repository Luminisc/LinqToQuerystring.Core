namespace LinqToQuerystring.TreeNodes.DataTypes
{
    using Antlr.Runtime;
    using LinqToQuerystring.TreeNodes.Base;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;

    public class DecimalNode : TreeNode
    {
        public DecimalNode(Type inputType, IToken payload, TreeNodeFactory treeNodeFactory)
            : base(inputType, payload, treeNodeFactory)
        {
        }

        public override Expression BuildLinqExpression(IQueryable query, Expression expression, Expression item = null)
        {
            return Expression.Constant(Convert.ToDecimal(this.Text.Replace("m", string.Empty), CultureInfo.InvariantCulture));
        }
    }
}