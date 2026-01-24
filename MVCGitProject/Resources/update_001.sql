ALTER TABLE public."users"
ADD COLUMN IF NOT EXISTS password character varying(255) NOT NULL DEFAULT '';
