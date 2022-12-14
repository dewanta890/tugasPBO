PGDMP     8    "                z            DataSekolah    15.1    15.1                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            	           1262    16397    DataSekolah    DATABASE     ?   CREATE DATABASE "DataSekolah" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Indonesian_Indonesia.1252';
    DROP DATABASE "DataSekolah";
                postgres    false            ?            1259    16427    absensi    TABLE       CREATE TABLE public.absensi (
    tanggal_absen date,
    pegawai_nip numeric,
    waktu_absen timestamp without time zone,
    waktu_pulang timestamp without time zone,
    uid integer NOT NULL,
    status character varying(32),
    img_ijin character varying(256)
);
    DROP TABLE public.absensi;
       public         heap    postgres    false            ?            1259    16441    absensi_uid_seq    SEQUENCE     ?   CREATE SEQUENCE public.absensi_uid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.absensi_uid_seq;
       public          postgres    false    215            
           0    0    absensi_uid_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.absensi_uid_seq OWNED BY public.absensi.uid;
          public          postgres    false    216            ?            1259    16398    pegawai    TABLE     D  CREATE TABLE public.pegawai (
    nip numeric(32,0) DEFAULT 0 NOT NULL,
    nama_pegawai character varying(128),
    tanggal_lahir date,
    no_handphone numeric(15,0),
    email character varying(64),
    pass character varying(32),
    domisili text,
    jabatan character varying(12),
    uid_pegawai integer NOT NULL
);
    DROP TABLE public.pegawai;
       public         heap    postgres    false            ?            1259    16450    pegawai_uid_pegawai_seq    SEQUENCE     ?   CREATE SEQUENCE public.pegawai_uid_pegawai_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.pegawai_uid_pegawai_seq;
       public          postgres    false    214                       0    0    pegawai_uid_pegawai_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.pegawai_uid_pegawai_seq OWNED BY public.pegawai.uid_pegawai;
          public          postgres    false    217            l           2604    16442    absensi uid    DEFAULT     j   ALTER TABLE ONLY public.absensi ALTER COLUMN uid SET DEFAULT nextval('public.absensi_uid_seq'::regclass);
 :   ALTER TABLE public.absensi ALTER COLUMN uid DROP DEFAULT;
       public          postgres    false    216    215            k           2604    16451    pegawai uid_pegawai    DEFAULT     z   ALTER TABLE ONLY public.pegawai ALTER COLUMN uid_pegawai SET DEFAULT nextval('public.pegawai_uid_pegawai_seq'::regclass);
 B   ALTER TABLE public.pegawai ALTER COLUMN uid_pegawai DROP DEFAULT;
       public          postgres    false    217    214                      0    16427    absensi 
   TABLE DATA           o   COPY public.absensi (tanggal_absen, pegawai_nip, waktu_absen, waktu_pulang, uid, status, img_ijin) FROM stdin;
    public          postgres    false    215   c                  0    16398    pegawai 
   TABLE DATA           ~   COPY public.pegawai (nip, nama_pegawai, tanggal_lahir, no_handphone, email, pass, domisili, jabatan, uid_pegawai) FROM stdin;
    public          postgres    false    214   ?                  0    0    absensi_uid_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.absensi_uid_seq', 35, true);
          public          postgres    false    216                       0    0    pegawai_uid_pegawai_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.pegawai_uid_pegawai_seq', 60, true);
          public          postgres    false    217            p           2606    16449    absensi absensi_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.absensi
    ADD CONSTRAINT absensi_pkey PRIMARY KEY (uid);
 >   ALTER TABLE ONLY public.absensi DROP CONSTRAINT absensi_pkey;
       public            postgres    false    215            n           2606    16414    pegawai pegawai_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.pegawai
    ADD CONSTRAINT pegawai_pkey PRIMARY KEY (nip);
 >   ALTER TABLE ONLY public.pegawai DROP CONSTRAINT pegawai_pkey;
       public            postgres    false    214            q           2606    16432    absensi pegawai_nip    FK CONSTRAINT     ?   ALTER TABLE ONLY public.absensi
    ADD CONSTRAINT pegawai_nip FOREIGN KEY (pegawai_nip) REFERENCES public.pegawai(nip) MATCH FULL NOT VALID;
 =   ALTER TABLE ONLY public.absensi DROP CONSTRAINT pegawai_nip;
       public          postgres    false    214    3182    215                 x???Mj?0???)|???4???l?h?؁j0?}%?6?i?a6z?o??Q??A4????[ V/?H.[N1Z?!?bzs}+??lA???????"H_?P<??%?,>?w?d?aYW??<C??F?m!l?2/? Z?O޷?+Ǫɑ???X?w?Eê????FRud#??????`?t`???#?B>?_0?bPk??0?{???I_?v?8????ĺ|X????Wޑ>*??"4%?%=R{o?y???S?y??G???\m?4?l??x          ?   x?M?1?0Eg?9@?b??v??????C#?IQ(BܞP?ğl?}??,??'&??G#???F?.?bi?1????~???{۹?N??y??|??2d=?@?դ?Q?R?&??>??}D???C?p?r????rU?3?g??B-???L?l??e???9??l???&??B)?R#DR     