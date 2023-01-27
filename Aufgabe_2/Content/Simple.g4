grammar Simple;

program: line* EOF;

line: statement | ifBlock | whileBlock;

statement: (assignment | functionCall)';';

ifBlock: 'if' expression block ('else' elseIfBlock)?;

elseIfBlock: block | ifBlock;

whileBlock: WHILE expression block ('else' elseIfBlock);

WHILE: 'while' | 'until';

assignment: IDENTIFIER '=' expression;

functionCall: IDENTIFIER '(' (expression (',' expression)*)? ')';

expression
    : constant                          #constantExpression           
    | IDENTIFIER                        #identifierExpression
    | functionCall                      #functionCallExpression
    | '(' expression ')'                #paranthesizedExpression
    | '!' expression                    #notExpression
    | expression multOp expression      #multiplicationExpression
    | expression addOp expression       #additivationExpression
    | expression compareOp expression   #comparisonExpression
    | expression boolOp expression      #booleanExpression
    ;

multOp: '*' | '/' | '%';
addOp: '+' | '-';
compareOp: '==' | '!=' | '>' | '<' | '>=' | '<=';
boolOp: BOOL_OPERATORE;

BOOL_OPERATORE: 'and' | 'or' | 'xor';

constant: INTEGER | FLOAT | STRING | BOOL | NULL;

INTEGER: [0-9]+;
FLOAT: [0-9]+ '.' [0-9]+;
STRING: ('"' ~'"'* '"') | ('\'' ~'\''*'\'');
BOOL: 'true' | 'false';
NULL: 'null';

block: '{' line* '}';

WS: [ \t\r\n]+ -> skip;
IDENTIFIER: [a-zA-Z_][a-zA-Z0-9_]*;
