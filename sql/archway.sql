--archway / toran program

declare
    n number := &n;
    i number;
    j number;
    k number;
begin

    for i in 1..n loop
    dbms_output.put('->');
        for j in 1..n loop
            for k in 1..i-1 loop   --1.
                dbms_output.put(' ');
            end loop;

            for k in i..n loop        --2.
                dbms_output.put('-');
            end loop;

            for k in i..n-1 loop      --3.
                dbms_output.put('-');
            end loop;

            for k in 2..i  loop       --4.
                dbms_output.put(' ');
            end loop;
            dbms_output.put(' ');
        end loop;
        dbms_output.new_line;
    end loop;
end;